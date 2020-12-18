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
            string query = "INSERT INTO PARCEL(Name, Description) VALUES(@Name, @Description) RETURNING Id";
            string lastParcel = "SELECT id, name, description FROM parcel WHERE id = @IdLastParcel";
            int idLastParcel = await _dbConnection.ExecuteAsync(query, parcel);
            return await _dbConnection.QueryFirstAsync<Parcel>(lastParcel, new {IdLastParcel=idLastParcel});
        }
    }
}