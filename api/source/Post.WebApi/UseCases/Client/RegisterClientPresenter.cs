using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Client;

namespace Post.WebApi.UseCases.Client 
{
    public sealed class RegisterClientPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(CreateClientOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}