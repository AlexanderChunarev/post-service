using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Car;
using Dapper;

namespace Post.Infrastructure.Repositories.Car
{
    public class CarRepository : ICarRepository
    {
        private readonly IDbConnection _dbConnection;

        public CarRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task AddCar(Domain.Car.Car car)
        {
            string query = "INSERT INTO car(model, typename) VALUES(@Model, @TypeName)";
            await _dbConnection.ExecuteAsync(query, car);
        }

        public async Task<Domain.Car.Car> GetCarById(int carId)
        {
            string query = "SELECT * FROM car WHERE id=@CarId";
            return await _dbConnection.QueryFirstAsync<Domain.Car.Car>(query, new {CarId = carId});
        }
    }
}