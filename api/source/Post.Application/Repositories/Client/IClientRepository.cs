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
        Task<IEnumerable<Order>> GetDeparture(int idClient);
        Task<IEnumerable<Order>> GetReceiving(string phoneNumber);
    }
}