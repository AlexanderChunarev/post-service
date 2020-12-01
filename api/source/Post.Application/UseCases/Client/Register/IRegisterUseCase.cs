using System.Threading.Tasks;
using Post.Application.Boundaries.Client;

namespace Post.Application.UseCases.Client.Register
{
    public interface IRegisterClientUseCase 
    {
        Task Execute(CreateClientInput input);
    }
}