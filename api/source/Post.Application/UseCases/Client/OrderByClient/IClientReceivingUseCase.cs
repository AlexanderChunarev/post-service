using System.Threading.Tasks;

namespace Post.Application.UseCases.Client.OrderByClient
{
    public interface IClientReceivingUseCase
    {
        Task Execute(string phoneNumber);
    }
}