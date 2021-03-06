using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Parcel;
using Dapper;

namespace Post.Infrastructure.Repositories.Parcel
{
    using Post.Domain.Parcel;
    public class ParcelRepository : IParcelRepository
    {
        private readonly IDbConnection _dbConnection;

        public ParcelRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Parcel> AddParcel(Domain.Parcel.Parcel parcel)
        {
            string query = "INSERT INTO PARCEL(Name, Description) VALUES(@Name, @Description) RETURNING *";
            return await _dbConnection.QueryFirstAsync<Parcel>(query, parcel);
        }

        public async Task<Parcel> GetParcelById(int parcelId)
        {
            string query = "SELECT id, name, description FROM parcel WHERE id = @IdParcel";
            return await _dbConnection.QueryFirstAsync<Parcel>(query, new {IdParcel = parcelId});
        }

        public async Task SetWeight(int orderId, double weight)
        {
            string query = "UPDATE parcel SET weight=@Weight WHERE id=@OrderId";
            await _dbConnection.ExecuteAsync(query, new{Weight = weight, OrderId = orderId});
        }
    }
}