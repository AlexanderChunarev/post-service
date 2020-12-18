using System.Threading.Tasks;
using Post.Application.Boundaries.Admin.Driver;
using Post.Application.Repositories.Driver;

namespace Post.Application.UseCases.Admin.Driver
{
    using Post.Application.Repositories.Car;
    using Post.Domain.Driver;
    public class RegisterDriverUseCase : IRegisterDriverUseCase
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository;
        private readonly ICreateDriverOutput _outputHandler;

        public RegisterDriverUseCase(IDriverRepository driverRepository, ICarRepository carRepository, ICreateDriverOutput outputHandler)
        {
            _driverRepository = driverRepository;
            _carRepository = carRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(CreateDriverInput _input)
        {
            if(_input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            
            var driver = new Driver(){
                Name = _input.Name,
                Surname = _input.Surname,
                Phone  = _input.Phone,
                CarId = _input.CarId
            };
            await _driverRepository.AddDriver(driver);

            var car = _carRepository.GetCarById(_input.CarId);
            var driverOutput = new CreateDriverOutput(_input.Name, _input.Surname, _input.Phone, car.Result);
            _outputHandler.Standard(driverOutput);
        }
    }
}