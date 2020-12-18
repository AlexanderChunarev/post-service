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

        public async Task<IEnumerable<Domain.Order.Order>> GetSentOrders(int userId)
        {
            string query = "SELECT * from orders WHERE senderid=@IdClient";
            return await _dbConnection.QueryAsync<Domain.Order.Order>(query, new {IdClient = userId});
        }

        public async Task<IEnumerable<Domain.Order.Order>> GetReceivingOrders(string phoneNumber)
        {
            string query = "SELECT * FROM orders WHERE recipientphonenumber=@PhoneNumber";
            return await _dbConnection.QueryAsync<Domain.Order.Order>(query, new {PhoneNumber = phoneNumber});
        }

        public async Task<Domain.User.User> GetById(int id)
        {
            string query = "SELECT * FROM client WHERE id=@Id";
            return await _dbConnection.QueryFirstAsync<Domain.User.User>(query, new {Id = id});
        }

        public async Task<Domain.User.User> GetUserByCredentials(string login, string password)
        {
            string query = "SELECT * FROM client WHERE email=@Login AND password=@Password";
            return await _dbConnection.QueryFirstAsync<Domain.User.User>(query,
                new {Login = login, Password = password});
        }

        public async Task Register(Domain.User.User user)
        {
            string query =
                "INSERT INTO client (name, surname, email, phonenumber, password) VALUES (@Name, @Surname, @Email, @Phonenumber, @Password)";
            await _dbConnection.ExecuteAsync(query, user);
        }

        public async Task Update(int id, Domain.User.User user)
        {
            string query = "UPDATE client " +
                           "SET name = @Name, surname = @Surname, email = @Email, phonenumber = @Phonenumber " +
                           $"WHERE id = {id}";
            await _dbConnection.ExecuteAsync(query, user);
        }
    }
}