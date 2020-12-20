using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Post.Application.Boundaries.Order;
using Post.Application.Repositories.Client;
using Post.Application.Repositories.Deliver;
using Post.Application.Repositories.Driver;
using Post.Application.Repositories.Parcel;

namespace Post.Application.UseCases.Client.OrderByClient
{
    public class ClientReceivingUseCase : IGetOrdersUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IParcelRepository _parcelRepository;
        private readonly IDriverRepository _driverRepository;
        private readonly IDeliveryRepository _deleiveryRepository;
        private readonly IOutputReceivingOrders _outputHandler;

        public ClientReceivingUseCase(IClientRepository clientRepository, IParcelRepository parcelRepository, IDriverRepository driverRepository, IDeliveryRepository deleiveryRepository, IOutputReceivingOrders outputHandler)
        {
            _clientRepository = clientRepository;
            _parcelRepository = parcelRepository;
            _driverRepository = driverRepository;
            _deleiveryRepository = deleiveryRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(GetOrdersInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            System.Console.WriteLine(input.Phone);
            var orders = await _clientRepository.GetReceivingOrders(input.Phone);
            List<CreateOrdersOutput> outputOrders = new List<CreateOrdersOutput>();
            CreateOrdersOutput tempOutput;
            foreach (var o in orders)
            {
                System.Console.WriteLine(o.SenderId);
                var sender = _clientRepository.GetById(o.SenderId);
                var parcel = _parcelRepository.GetParcelById(o.ParcelId);
                tempOutput = new CreateOrdersOutput(o.Id, sender.Result, o.RecipientName, o.RecipientSurname, parcel.Result, o.Status);
                outputOrders.Add(tempOutput);
            }
            _outputHandler.Standard(outputOrders);
        }
    }
}