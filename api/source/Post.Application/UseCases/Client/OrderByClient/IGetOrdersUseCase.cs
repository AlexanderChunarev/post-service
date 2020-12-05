using System.Threading.Tasks;
using Post.Application.Boundaries.Order;

namespace Post.Application.UseCases.Client.OrderByClient
{
    
    public interface IGetOrdersUseCase
    {
        Task Execute(GetOrdersInput input);
    }
}