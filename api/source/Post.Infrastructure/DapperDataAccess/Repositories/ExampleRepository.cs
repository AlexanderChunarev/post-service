using System;
using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories;
using Post.Domain;

namespace Post.Infrastructure.DapperDataAccess.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly IDbConnection _dbConnection;

        public ExampleRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Task Add(Template airline)
        {
            // Run sql queries here
            throw new NotImplementedException();
        }
    }
}