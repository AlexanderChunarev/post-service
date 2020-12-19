using System.Threading.Tasks;
using Post.Application.Boundaries.Admin.RegisterDelivery;
using Post.Application.Repositories.Deliver;
using Post.Application.Repositories.Driver;
using Post.Application.Repositories.Order;
using Post.Application.Repositories.Parcel;
using Post.Domain.Delivery;

namespace Post.Application.UseCases.Admin
{
    public class RegisterDeliveryUseCase : IRegisterDeliveryUseCase
    {
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IParcelRepository _parcelRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IRegisterDeliveryOutput _outputHandler;

        public RegisterDeliveryUseCase(IDeliveryRepository deliveryRepository, IParcelRepository parcelRepository, IDriverRepository driverRepository, IOrderRepository orderRepository, IRegisterDeliveryOutput outputHandler)
        {
            _deliveryRepository = deliveryRepository;
            _parcelRepository = parcelRepository;
            _driverRepository = driverRepository;
            _orderRepository = orderRepository;
            _outputHandler = outputHandler;
        }

        public async Task Excute(RegisterDeliveryInput _input)
        {
            if(_input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }

            var delivery = new Delivery(){
                OrderId = _input.OrderId,
                DriverId = _input.DriverId,
                StartPlace = _input.StartPlace,
                FinishPlace = _input.FinishPlace
            };
            await _parcelRepository.SetWeight(_input.OrderId, _input.Weight);
            await _deliveryRepository.AddDelivery(delivery);

            var order = _orderRepository.GetOrderById(_input.OrderId);
            var driver = _driverRepository.GetDriverById(_input.DriverId);
            var deliveryOutput = new RegisterDeliveryOutput(order.Result, driver.Result, _input.StartPlace, _input.FinishPlace);

            _outputHandler.Standard(deliveryOutput);
        }
    }
}