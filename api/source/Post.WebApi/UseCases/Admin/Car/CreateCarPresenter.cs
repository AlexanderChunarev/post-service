using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Admin.Car;

namespace Post.WebApi.UseCases.Admin.Car 
{
    public sealed class CreateCarPresenter : ICarOutput
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(CreateCarOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}