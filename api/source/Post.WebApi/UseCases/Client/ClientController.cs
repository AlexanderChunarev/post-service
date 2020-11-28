using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Client;
using Post.Application.UseCases.Client;

namespace Post.WebApi.UseCases.Client
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IRegisterClientUseCase _registerClientUseCase;
        private readonly RegisterClientPresenter _registerClientPresenter;

        public ClientController(IRegisterClientUseCase registerClientUseCase, RegisterClientPresenter registerClientPresenter)
        {
            _registerClientUseCase = registerClientUseCase;
            _registerClientPresenter = registerClientPresenter;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateClientInput input)
        {
            await _registerClientUseCase.Execute(input);
            return _registerClientPresenter.ViewModel;
        }
    }
}