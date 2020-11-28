using System.Threading.Tasks;
using Post.Application.Boundaries.Client;

namespace Post.Application.UseCases.Client
{
    public interface IRegisterClientUseCase 
    {
        Task Execute(CreateClientInput input);
    }
}