using Microsoft.AspNetCore.Mvc;
using Post.Application.UseCases.Parcel;

namespace Post.WebApi.UseCases.Parcel
{
    using System.Threading.Tasks;
    using Post.Application.Boundaries.Parcel;
    [ApiController]
    [Route("api/[controller]")]
    public class ParcelController : Controller
    {
        private readonly ICreateParcelUseCase _createParcelUseCase;
        private readonly ParcelPresenter _parcelPresenter;

        public ParcelController(ICreateParcelUseCase createParcelUseCase, ParcelPresenter parcelPresenter)
        {
            _createParcelUseCase = createParcelUseCase;
            _parcelPresenter = parcelPresenter;
        }

        [HttpPost("add-parcel")]
        public async Task<IActionResult> AddParcel(CreateParcelInput _input)
        {
            await _createParcelUseCase.Exucute(_input);
            return _parcelPresenter.ViewModel;
        }
    }
}