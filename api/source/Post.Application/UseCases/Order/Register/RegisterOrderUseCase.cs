using System.Threading.Tasks;
using Post.Application.Boundaries.Order;
using Post.Application.Repositories.Order;

namespace Post.Application.UseCases.Order.Register
{
    using Post.Domain.Order;
    public class RegisterOrderUseCase : IRegisterOrderUseCase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOutputPort _outputHandler;

        public RegisterOrderUseCase(IOrderRepository orderRepository, IOutputPort outputHandler)
        {
            _orderRepository = orderRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(CreateOrderInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            var order = new Order(){
                SenderId = input.SenderId,
                RecipientName = input.RecipientName,
                RecipientSurname = input.RecipientSurname,
                RecipientPhonenumber = input.RecipientPhoneNumber,
                Status = input.Status
            };
            await _orderRepository.RegisterOrder(order);
            var createOrderOutput = new CreateOrderOutput(
                input.SenderId,
                input.RecipientName,
                input.RecipientSurname,
                input.RecipientPhoneNumber,
                0,
                input.Status
                );
             _outputHandler.Standard(createOrderOutput);   
        }
    }
}