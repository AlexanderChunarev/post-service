using System.Threading.Tasks;
using Post.Application.Boundaries.Order;
using Post.Application.Repositories.Order;

namespace Post.Application.UseCases.Order.Register
{
    using Post.Application.Repositories.Parcel;
    using Post.Domain.Order;
    using Post.Domain.Parcel;

    public class RegisterOrderByAdmin : IRegisterOrderUseCase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IParcelRepository _parcelRepository;
        private readonly IOutputPort _outputHandler;

        public RegisterOrderByAdmin(IOrderRepository orderRepository, IParcelRepository parcelRepository, IOutputPort outputHandler)
        {
            _orderRepository = orderRepository;
            _parcelRepository = parcelRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(CreateOrderInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }

            var parcel = new Parcel(){
                Name = input.ParcelName,
                Description = input.ParcelDescription
            };
            var Parcel = await _parcelRepository.AddParcel(parcel);
            var order = new Order(){
                SenderId = input.SenderId,
                RecipientName = input.RecipientName,
                RecipientSurname = input.RecipientSurname,
                RecipientPhonenumber = input.RecipientPhoneNumber,
                ParcelId = Parcel.Id,
                Status = input.Status
            };
            await _orderRepository.RegisterOrder(order);
            var createOrderOutput = new CreateOrderOutput(
                input.SenderId,
                input.RecipientName,
                input.RecipientSurname,
                input.RecipientPhoneNumber,
                Parcel,
                input.Status
                );
             _outputHandler.Standard(createOrderOutput);   
        }
    }
}