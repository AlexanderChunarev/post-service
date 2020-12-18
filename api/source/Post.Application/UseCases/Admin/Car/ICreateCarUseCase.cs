using System.Threading.Tasks;
using Post.Application.Boundaries.Admin.Car;

namespace Post.Application.UseCases.Admin.Car
{
    public interface ICreateCarUseCase
    {
        Task Execute(CreateCarInput _input);
    }
}