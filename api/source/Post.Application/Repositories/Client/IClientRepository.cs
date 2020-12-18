namespace Post.Application.Repositories.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Post.Domain.Client;
    using Post.Domain.Order;
    
    public interface IClientRepository
    {
        Task<User> GetById(int id);
        Task<User> GetUserByCredentials(string userName, string password);
        Task Register(User user);
        Task Update(int id, User user);
        Task<IEnumerable<Order>> GetSentOrders(int userId);
        Task<IEnumerable<Order>> GetReceivingOrders(string phoneNumber);
    }
}