using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Order;

namespace Post.WebApi.UseCases.Order
{
    public sealed class RegisterOrderPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(CreateOrderOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}