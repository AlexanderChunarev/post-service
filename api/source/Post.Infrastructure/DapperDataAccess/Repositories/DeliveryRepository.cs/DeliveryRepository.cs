using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Deliver;
using Dapper;

namespace Post.Infrastructure.Repositories.Delivery
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly IDbConnection _dbConnection;
        public DeliveryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task AddDelivery(Domain.Delivery.Delivery delivery)
        {
            string query = "INSERT INTO delivery(orderid, driverid, startplace, fifnishplace) VALUES(@OrderId, @DriverId, @StartPlace, @FinishPlace)";
            await _dbConnection.ExecuteAsync(query, delivery);
        }

        
    }
}