using System.Threading.Tasks;

namespace Post.Application.UseCases.Client.OrderByClient
{
    public interface IClientDepartureUseCase
    {
        Task Execute(int? idClient);
    }
}