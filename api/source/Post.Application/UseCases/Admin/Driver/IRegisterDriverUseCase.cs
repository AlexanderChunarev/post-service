using System.Threading.Tasks;
using Post.Application.Boundaries.Admin.Driver;

namespace Post.Application.UseCases.Admin.Driver
{
    public interface IRegisterDriverUseCase
    {
        Task Execute(CreateDriverInput _input);
    }
}