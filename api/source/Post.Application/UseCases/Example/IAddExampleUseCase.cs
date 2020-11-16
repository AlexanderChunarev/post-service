using System.Threading.Tasks;
using Post.Application.Boundaries.Example;

namespace Post.Application.UseCases.Example
{
    public interface IAddExampleUseCase
    {
        Task Execute(ExampleInput airlineInput);
    }
}