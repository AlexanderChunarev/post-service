using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Parcel;

namespace Post.WebApi.UseCases.Parcel
{
    public sealed class ParcelPresenter : IParcelOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(CreateParcelOutput output)
        {
            ViewModel = new JsonResult(output);
        }
    }
}