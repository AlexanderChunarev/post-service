using System.Threading.Tasks;

namespace Post.Application.Repositories.Order
{
    using Post.Domain.Order;
    public interface IOrderRepository
    {
        Task RegisterOrder(Order order);
        Task<Order> GetOrderById(int orderId);
    }
}