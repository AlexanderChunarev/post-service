namespace Post.Application.Repositories.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Post.Domain.Client;
    using Post.Domain.Order;
    
    public interface IClientRepository 
    {
        Task Register(Client client);
        Task Update(int id, Client client);
        Task<IEnumerable<Order>> GetSendedOrders(int idClient);
        Task<IEnumerable<Order>> GetReceivingOrders(string phoneNumber);
    }
}