using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Admin.Car;
using Post.Application.UseCases.Admin.Car;

namespace Post.WebApi.UseCases.Admin.Car
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICreateCarUseCase _createCarUseCase;
        private readonly CreateCarPresenter _registerCarPresenter;

        public CarController(ICreateCarUseCase createCarUseCase, CreateCarPresenter registerCarPresenter)
        {
            _createCarUseCase = createCarUseCase;
            _registerCarPresenter = registerCarPresenter;
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddCar([FromBody] CreateCarInput _input)
        {
            await _createCarUseCase.Execute(_input);
            return _registerCarPresenter.ViewModel;
        }
    }
}