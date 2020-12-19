using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Admin.Driver;

namespace Post.WebApi.UseCases.Admin.Driver
{
    public sealed class RegisterDriverPresenter : ICreateDriverOutput
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(CreateDriverOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}