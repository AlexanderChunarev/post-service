using System.Threading.Tasks;

namespace Post.Application.Repositories.Car
{
    using Post.Domain.Car;
    public interface ICarRepository
    {
        Task AddCar(Car car);
        Task<Car> GetCarById(int carId);
    }
}