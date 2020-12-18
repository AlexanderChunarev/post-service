namespace Post.Application.Repositories.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Post.Domain.Client;
    using Post.Domain.Order;
    
    public interface IClientRepository
    {
        Task<Client> GetById(int id);
        Task<Client> GetClientByCredentials(string userName, string password);
        Task Register(Client client);
        Task Update(int id, Client client);
        Task<IEnumerable<Order>> GetSentOrders(int idClient);
        Task<IEnumerable<Order>> GetReceivingOrders(string phoneNumber);
    }
}