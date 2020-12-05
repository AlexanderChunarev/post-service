using System;
using System.Data;
using System.Threading.Tasks;
using Post.Application.Repositories.Client;
using Post.Domain.Client;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Post.Infrastructure.DapperDataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDbConnection _dbConnection;

        public ClientRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Domain.Order.Order>> GetDeparture(int idClient)
        {
            string query = "SELECT * from orders WHERE senderid=@IdClient";
            return await _dbConnection.QueryAsync<Domain.Order.Order>(query, new { IdClient = idClient });
        }

        public async Task<IEnumerable<Domain.Order.Order>> GetReceiving(string phoneNumber)
        {
            string query = "SELECT * FROM orders WHERE recipientphonenumber=@PhoneNumber";
            return await _dbConnection.QueryAsync<Domain.Order.Order>(query, new { PhoneNumber = phoneNumber });
        }

        public async Task Register(Client client)
        {
            string query = "INSERT INTO client (name, surname, email, phonenumber) VALUES (@Name, @Surname, @Email, @Phonenumber)";
            await _dbConnection.ExecuteAsync(query, client);
        }

        public async Task Update(int id, Client client)
        {
            string query = "UPDATE client " +
                            "SET name = @Name, surname = @Surname, email = @Email, phonenumber = @Phonenumber " +
                            $"WHERE id = {id}";
            await _dbConnection.ExecuteAsync(query, client);
        }
    }
}