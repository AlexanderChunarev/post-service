using System.Threading.Tasks;
using Post.Application.Boundaries.Client;
using Post.Application.Repositories.Client;

namespace Post.Application.UseCases.Client
{
    using Post.Domain.Client;
    public class RegisterClientUseCase : IRegisterClientUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IOutputPort _outputHandler;

        public RegisterClientUseCase(IClientRepository clientRepository, IOutputPort outputHandler)
        {
            _clientRepository = clientRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(CreateClientInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            System.Console.WriteLine(input == null);
            var client = new Client(){
                Name = input.Name,
                Surname = input.Surname,
                PhoneNumber = input.PhoneNumber,
                Email = input.Email
            };
            await _clientRepository.Register(client);
            var createClientOutput = new CreateClientOutput(client.Name, client.Surname, client.PhoneNumber, client.Email);
            _outputHandler.Standard(createClientOutput);
        }
    }
}