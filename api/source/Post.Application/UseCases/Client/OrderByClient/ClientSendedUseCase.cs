using System.Collections.Generic;
using System.Threading.Tasks;
using Post.Application.Boundaries.Order;
using Post.Application.Repositories.Client;
using Post.Application.Repositories.Parcel;

namespace Post.Application.UseCases.Client.OrderByClient
{
    public class ClientSendedOrdersUseCase : IGetOrdersUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IParcelRepository _parcelRepository;
        private readonly IOutputSendedOrders _outputHandler;

        public ClientSendedOrdersUseCase(IClientRepository clientRepository, IParcelRepository parcelRepository, IOutputSendedOrders outputHandler)
        {
            _clientRepository = clientRepository;
            _parcelRepository = parcelRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(GetOrdersInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            var orders = await _clientRepository.GetSentOrders(input.SenderId);
            List<CreateOrdersOutput> outputOrders = new List<CreateOrdersOutput>();
            CreateOrdersOutput tempOutput;
            foreach (var o in orders)
            {
                var sender = _clientRepository.GetById(o.SenderId);
                var parcel = _parcelRepository.GetParcelById(o.ParcelId);
                tempOutput = new CreateOrdersOutput(o.Id, sender.Result, o.RecipientName, o.RecipientSurname, parcel.Result, o.Status);
                outputOrders.Add(tempOutput);
            }
            _outputHandler.Standard(outputOrders);
        }
    }
} 