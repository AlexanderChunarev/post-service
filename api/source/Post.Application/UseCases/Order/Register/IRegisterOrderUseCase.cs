using System.Threading.Tasks;
using Post.Application.Boundaries.Order;

namespace Post.Application.UseCases.Order.Register
{
    public interface IRegisterOrderUseCase
    {
        Task Execute(CreateOrderInput input);
    }
}