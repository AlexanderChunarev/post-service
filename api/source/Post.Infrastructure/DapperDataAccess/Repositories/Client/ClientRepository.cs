using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Post.Application.Repositories.Client;

namespace Post.Infrastructure.DapperDataAccess.Repositories.Client
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDbConnection _dbConnection;

        public ClientRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Domain.Order.Order>> GetSentOrders(int idClient)
        {
            string query = "SELECT * from orders WHERE senderid=@IdClient";
            return await _dbConnection.QueryAsync<Domain.Order.Order>(query, new {IdClient = idClient});
        }

        public async Task<IEnumerable<Domain.Order.Order>> GetReceivingOrders(string phoneNumber)
        {
            string query = "SELECT * FROM orders WHERE recipientphonenumber=@PhoneNumber";
            return await _dbConnection.QueryAsync<Domain.Order.Order>(query, new {PhoneNumber = phoneNumber});
        }

        public async Task<Domain.Client.Client> GetById(int id)
        {
            string query = "SELECT * FROM client WHERE id=@Id";
            return await _dbConnection.QueryFirstAsync<Domain.Client.Client>(query, new {Id = id});
        }

        public async Task<Domain.Client.Client> GetClientByCredentials(string login, string password)
        {
            string query = "SELECT * FROM client WHERE email=@Login AND password=@Password";
            return await _dbConnection.QueryFirstAsync<Domain.Client.Client>(query,
                new {Login = login, Password = password});
        }

        public async Task Register(Domain.Client.Client client)
        {
            string query =
                "INSERT INTO client (name, surname, email, phonenumber, password) VALUES (@Name, @Surname, @Email, @Phonenumber, @Password)";
            await _dbConnection.ExecuteAsync(query, client);
        }

        public async Task Update(int id, Domain.Client.Client client)
        {
            string query = "UPDATE client " +
                           "SET name = @Name, surname = @Surname, email = @Email, phonenumber = @Phonenumber " +
                           $"WHERE id = {id}";
            await _dbConnection.ExecuteAsync(query, client);
        }
    }
}