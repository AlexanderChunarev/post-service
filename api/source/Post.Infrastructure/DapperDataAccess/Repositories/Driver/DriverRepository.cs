using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Driver;
using Dapper;

namespace Post.Infrastructure.Repositories.Driver
{
    public class DriverRepository : IDriverRepository
    {
        private readonly IDbConnection _dbConnection;

        public DriverRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task AddDriver(Domain.Driver.Driver driver)
        {
            string query = "INSERT INTO driver(name, surname, phone, carid) VALUES(@Name, @Surname, @Phone, @CarId)";
            await _dbConnection.ExecuteAsync(query, driver);
        }

        public async Task<Domain.Driver.Driver> GetDriverById(int driverId)
        {
            string query = "SELECT * FROM driver WHERE id=@DriverId";
            return await _dbConnection.QueryFirstAsync<Domain.Driver.Driver>(query, new {DriverId = driverId});
        }
    }
}