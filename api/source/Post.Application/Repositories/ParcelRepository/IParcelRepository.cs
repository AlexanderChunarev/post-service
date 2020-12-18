using System.Threading.Tasks;

namespace Post.Application.Repositories.Parcel
{
    using Post.Domain.Parcel;
    public interface IParcelRepository
    {
        Task<int> AddParcel(Parcel parcel);
    }
}