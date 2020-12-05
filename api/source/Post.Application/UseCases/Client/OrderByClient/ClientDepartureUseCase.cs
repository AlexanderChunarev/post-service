using System.Linq;
using System.Threading.Tasks;
using Post.Application.Boundaries.Client;
using Post.Application.Boundaries.Order;
using Post.Application.Repositories.Client;

namespace Post.Application.UseCases.Client.OrderByClient
{
    public class ClientDepartureUseCase : IGetOrdersUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IOutputDepartureOrders _outputHandler;
        const int DefaultIdClient = 0;

        public ClientDepartureUseCase(IClientRepository clientRepository, IOutputDepartureOrders outputHandler)
        {
            _clientRepository = clientRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(GetOrdersInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            var orders = await _clientRepository.GetDeparture(input.SenderId);
            _outputHandler.Standard(new CreateOrdersOutput(orders.ToList()));
        }
    }
} 