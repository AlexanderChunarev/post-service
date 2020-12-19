using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Admin.Driver;
using Post.Application.Boundaries.Admin.RegisterDelivery;

namespace Post.WebApi.UseCases.Admin.Delivery
{
    public sealed class RegisterDeliveryPresenter : IRegisterDeliveryOutput
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(RegisterDeliveryOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}