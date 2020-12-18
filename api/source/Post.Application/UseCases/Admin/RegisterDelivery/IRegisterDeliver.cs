using System.Threading.Tasks;
using Post.Application.Boundaries.Admin.RegisterDelivery;

namespace Post.Application.UseCases.Admin
{
    public interface IRegisterDeliveryUseCase
    {
        Task Excute(RegisterDeliveryInput _input);
    }
}