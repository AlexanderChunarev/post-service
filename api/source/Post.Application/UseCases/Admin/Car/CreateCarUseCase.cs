using System.Threading.Tasks;
using Post.Application.Boundaries.Admin.Car;
using Post.Application.Repositories.Car;

namespace Post.Application.UseCases.Admin.Car
{
    using Post.Domain.Car;
    public class CreateCarUseCase : ICreateCarUseCase
    {
        private readonly ICarRepository _carRepository;
        private readonly ICarOutput _outputHandler;

        public CreateCarUseCase(ICarRepository carRepository, ICarOutput outputHandler)
        {
            _carRepository = carRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(CreateCarInput _input)
        {
            if(_input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }

            var car = new Car(){
                Model = _input.Model,
                TypeName = _input.TypeName
            };
            await _carRepository.AddCar(car);

            var carOutput = new CreateCarOutput(_input.Model, _input.TypeName);
            _outputHandler.Standard(carOutput);
        }
    }
}