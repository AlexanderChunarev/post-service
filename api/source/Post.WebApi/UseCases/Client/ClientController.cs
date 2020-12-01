using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Client;
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
        private readonly RegisterClientPresenter _registerClientPresenter;
        private readonly UpdateClientPresenter _updateClientPresenter;

        public ClientController(IRegisterClientUseCase registerClientUseCase, IUpdateClientUseCase updateClientUseCase, RegisterClientPresenter registerClientPresenter, UpdateClientPresenter updateClientPresenter)
        {
            _registerClientUseCase = registerClientUseCase;
            _updateClientUseCase = updateClientUseCase;
            _registerClientPresenter = registerClientPresenter;
            _updateClientPresenter = updateClientPresenter;
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
    }
}