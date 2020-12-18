using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Admin.Driver;
using Post.Application.UseCases.Admin.Driver;

namespace Post.WebApi.UseCases.Admin.Driver
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : Controller 
    {
        private readonly IRegisterDriverUseCase _registerDriverUseCase;
        private readonly RegisterDriverPresenter _registerDrivePresenter;

        public DriverController(IRegisterDriverUseCase registerDriverUseCase, RegisterDriverPresenter registerDrivePresenter)
        {
            _registerDriverUseCase = registerDriverUseCase;
            _registerDrivePresenter = registerDrivePresenter;
        }

        [HttpPost("register")]
        public async Task<IActionResult> AddDriver([FromBody] CreateDriverInput _input)
        {
            await _registerDriverUseCase.Execute(_input);
            return _registerDrivePresenter.ViewModel;
        }
    }
}