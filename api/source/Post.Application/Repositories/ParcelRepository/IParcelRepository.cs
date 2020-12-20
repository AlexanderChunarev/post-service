using System.Threading.Tasks;

namespace Post.Application.Repositories.Parcel
{
    using Post.Domain.Parcel;
    public interface IParcelRepository
    {
        Task<Parcel> AddParcel(Parcel parcel);
        Task<Parcel> GetParcelById(int parcelId);
        Task SetWeight(int orderId, double weight);
    }
}