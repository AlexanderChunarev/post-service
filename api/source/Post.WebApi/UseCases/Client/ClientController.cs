using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Client;
using Post.Application.Boundaries.Order;
using Post.Application.UseCases.Client.OrderByClient;
using Post.Application.UseCases.Client.Register;
using Post.Application.UseCases.Client.Update;

namespace Post.WebApi.UseCases.Client
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IRegisterClientUseCase _registerClientUseCase;
        private readonly IUpdateClientUseCase _updateClientUseCase;
        private readonly ClientSendedOrdersUseCase _getDepartureOrdersUseCase;
        private readonly ClientReceivingUseCase _getReceivingOrdersUseCase;
        private readonly RegisterClientPresenter _registerClientPresenter;
        private readonly UpdateClientPresenter _updateClientPresenter;
        private readonly ClientDeparturePresenter _clientDeparturePresenter;
        private readonly ClientReceivingPresenter _clientReceivingPresenter;

        public ClientController(IRegisterClientUseCase registerClientUseCase, IUpdateClientUseCase updateClientUseCase, ClientSendedOrdersUseCase getDepartureOrdersUseCase, ClientReceivingUseCase getReceivingOrdersUseCase, RegisterClientPresenter registerClientPresenter, UpdateClientPresenter updateClientPresenter, ClientDeparturePresenter clientDeparturePresenter, ClientReceivingPresenter clientReceivingPresenter)
        {
            _registerClientUseCase = registerClientUseCase;
            _updateClientUseCase = updateClientUseCase;
            _getDepartureOrdersUseCase = getDepartureOrdersUseCase;
            _getReceivingOrdersUseCase = getReceivingOrdersUseCase;
            _registerClientPresenter = registerClientPresenter;
            _updateClientPresenter = updateClientPresenter;
            _clientDeparturePresenter = clientDeparturePresenter;
            _clientReceivingPresenter = clientReceivingPresenter;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateClientInput input)
        {
            await _registerClientUseCase.Execute(input);
            return _registerClientPresenter.ViewModel;
        }

        [HttpPatch("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CreateClientInput input)
        {
            await _updateClientUseCase.Execute(id,input);
            return _updateClientPresenter.ViewModel;
        }

        [HttpGet("{id}/departure-orders")]
        public async Task<IActionResult> GetDepartureByClient(int id)
        {
            await _getDepartureOrdersUseCase.Execute(new GetOrdersInput(id));
            return _clientDeparturePresenter.ViewModel;
        }

        [HttpGet("{phone}/receiving-orders")]
        public async Task<IActionResult> GetReceivingOrders(string phone)
        {
            await _getReceivingOrdersUseCase.Execute(new GetOrdersInput(phone));
            return _clientReceivingPresenter.ViewModel;
        }
    }
}