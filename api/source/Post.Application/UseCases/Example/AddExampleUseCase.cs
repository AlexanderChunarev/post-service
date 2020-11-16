using System.Threading.Tasks;
using Post.Application.Boundaries.Example;
using Post.Application.Repositories;

namespace Post.Application.UseCases.Example
{
    public class AddExampleUseCase : IAddExampleUseCase
    {
        private readonly IExampleRepository _exampleRepository;
        private readonly IOutputPort _outputHandler;

        public AddExampleUseCase(IExampleRepository exampleRepository, IOutputPort outputHandler)
        {
            _exampleRepository = exampleRepository;
            _outputHandler = outputHandler;
        }

        public Task Execute(ExampleInput airlineInput)
        {
            throw new System.NotImplementedException();
        }
    }
}