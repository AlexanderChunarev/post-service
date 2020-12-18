using System.Threading.Tasks;
using Post.Application.Boundaries.Parcel;
using Post.Application.Repositories.Parcel;

namespace Post.Application.UseCases.Parcel
{
    using Post.Domain.Parcel;
    public class CreateParcelUseCase : ICreateParcelUseCase
    {
        private readonly IParcelRepository _parcelRepository;
        private readonly IParcelOutputPort _outputHandler;

        public CreateParcelUseCase(IParcelRepository parcelRepository, IParcelOutputPort outputHandler)
        {
            _parcelRepository = parcelRepository;
            _outputHandler = outputHandler;
        }

        public async Task Exucute(CreateParcelInput input)
        {
            if(input == null)
            {
               _outputHandler.Error("Input is null.");
                return; 
            }
            var parcel = new Parcel(){
                Name = input.Name,
                Description = input.Description
            };

            var id = await _parcelRepository.AddParcel(parcel);
            var createParcelOutput = new CreateParcelOutput(id);
            _outputHandler.Standard(createParcelOutput);
        }
    }
}