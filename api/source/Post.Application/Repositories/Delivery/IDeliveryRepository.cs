namespace Post.Application.Repositories.Deliver
{
    using System.Threading.Tasks;
    using Post.Domain.Delivery;
    public interface IDeliveryRepository
    {
        Task AddDelivery(Delivery delivery);
    }
}