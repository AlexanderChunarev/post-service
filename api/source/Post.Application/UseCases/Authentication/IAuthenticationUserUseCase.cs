using System.Threading.Tasks;
using Post.Application.Boundaries.Authentication;

namespace Post.Application.UseCases.Authentication
{
    public interface IAuthenticationUserUseCase
    {
        Task Execute(AuthenticationInput input);
    }
}