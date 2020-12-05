using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Order;

namespace Post.WebApi.UseCases.Client
{
    public sealed class ClientDeparturePresenter : IOutputSendedOrders
    {
        public IActionResult ViewModel { get; set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(CreateOrdersOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}