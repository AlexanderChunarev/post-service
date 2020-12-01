using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Order;
using Dapper;

namespace Post.Infrastructure.DapperDataAccess.Repositories.Order
{
    using Post.Domain.Order;
    public class OrderRepository : IOrderRepository
    {
        private readonly IDbConnection _dbConnection;

        public OrderRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task RegisterOrder(Order order)
        {
            string query = "INSERT INTO orders (senderid, recipientName, recipientSurname, recipientPhonenumber, weight, status)"
                            + " VALUES (@SenderId, @RecipientName, @RecipientSurname, @RecipientPhonenumber, @Weight, @Status)";
            await _dbConnection.ExecuteAsync(query,order);
        }
    }
}