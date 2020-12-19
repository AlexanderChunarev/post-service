using System.Threading.Tasks;

namespace Post.Application.Repositories.Driver
{
    using Post.Domain.Driver;
    public interface IDriverRepository
    {
        Task AddDriver(Driver driver);
        Task<Driver> GetDriverById(int driverId);
    }
}