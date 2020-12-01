using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Order;
using Post.Application.UseCases.Order.Register;

namespace Post.WebApi.UseCases.Order
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IRegisterOrderUseCase _registerClientUseCase;
        private readonly RegisterOrderPresenter _registerOrderPresenter;

        public OrderController(IRegisterOrderUseCase registerClientUseCase, RegisterOrderPresenter registerOrderPresenter)
        {
            _registerClientUseCase = registerClientUseCase;
            _registerOrderPresenter = registerOrderPresenter;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateOrderInput input)
        {
            await _registerClientUseCase.Execute(input);
            return _registerOrderPresenter.ViewModel;
        }
    }    
}