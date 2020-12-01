using System.Threading.Tasks;
using Post.Application.Boundaries.Client;

namespace Post.Application.UseCases.Client.Update
{
    public interface IUpdateClientUseCase 
    {
        Task Execute(int id,CreateClientInput input);
    }
}