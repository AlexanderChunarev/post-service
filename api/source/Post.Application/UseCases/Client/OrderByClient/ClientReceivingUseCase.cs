using System.Linq;
using System.Threading.Tasks;
using Post.Application.Boundaries.Order;
using Post.Application.Repositories.Client;

namespace Post.Application.UseCases.Client.OrderByClient
{
    public class ClientReceivingUseCase : IGetOrdersUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IOutputReceivingOrders _outputHandler;

        public ClientReceivingUseCase(IClientRepository clientRepository, IOutputReceivingOrders outputHandler)
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
            var orders = await _clientRepository.GetReceivingOrders(input.Phone);
            _outputHandler.Standard(new CreateOrdersOutput(orders.ToList()));
        }
    }
}