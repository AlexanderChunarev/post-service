using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Parcel;
using Dapper;

namespace Post.Infrastructure.Repositories.Parcel
{
    public class ParcelRepository : IParcelRepository
    {
        private readonly IDbConnection _dbConnection;

        public ParcelRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<int> AddParcel(Domain.Parcel.Parcel parcel)
        {
            string query = "INSERT INTO PARCEL(Name, Description) VALUES(@Name, @Description) RETURNING Id";
            return await _dbConnection.ExecuteAsync(query, parcel);
        }
    }
}