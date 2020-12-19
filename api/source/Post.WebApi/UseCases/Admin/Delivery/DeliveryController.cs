using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Admin.RegisterDelivery;
using Post.Application.UseCases.Admin;

namespace Post.WebApi.UseCases.Admin.Delivery
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : Controller 
    {
        private readonly IRegisterDeliveryUseCase _registerDeliveryUseCase;
        private readonly RegisterDeliveryPresenter _registerDeliveryPresenter;

        public DeliveryController(IRegisterDeliveryUseCase registerDeliveryUseCase, RegisterDeliveryPresenter registerDeliveryPresenter)
        {
            _registerDeliveryUseCase = registerDeliveryUseCase;
            _registerDeliveryPresenter = registerDeliveryPresenter;
        }

        [HttpPost("delivery-order")]
        public async Task<IActionResult> RegisterDelivery([FromBody] RegisterDeliveryInput _input)
        {
            await _registerDeliveryUseCase.Excute(_input);
            return _registerDeliveryPresenter.ViewModel;
        }
    }
}