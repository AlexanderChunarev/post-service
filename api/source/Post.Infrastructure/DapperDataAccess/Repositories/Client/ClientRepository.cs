using System;
using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Client;
using Post.Domain.Client;
using Dapper;

namespace Post.Infrastructure.DapperDataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDbConnection _dbConnection;

        public ClientRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task Register(Client client)
        {
            string query = "INSERT INTO client (name, surname, email, phonenumber) VALUES (@Name, @Surname, @Email, @Phonenumber)";
            await _dbConnection.ExecuteAsync(query, client);
        }

        public async Task Update(int id, Client client)
        {
            string query = "UPDATE client "+ 
                            "SET name = @Name, surname = @Surname, email = @Email, phonenumber = @Phonenumber "+
                            $"WHERE id = {id}";
            await _dbConnection.ExecuteAsync(query,client);
        }
    }
}