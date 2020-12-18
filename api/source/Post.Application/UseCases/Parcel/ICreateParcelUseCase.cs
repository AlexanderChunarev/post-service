using System.Threading.Tasks;
using Post.Application.Boundaries.Parcel;

namespace Post.Application.UseCases.Parcel
{
    public interface ICreateParcelUseCase
    {
        Task Exucute(CreateParcelInput input);
    }
}