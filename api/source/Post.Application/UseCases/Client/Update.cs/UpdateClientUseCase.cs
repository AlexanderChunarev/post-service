using System.Threading.Tasks;
using Post.Application.Boundaries.Client;
using Post.Application.Repositories.Client;

namespace Post.Application.UseCases.Client.Update
{
    using Domain.User;
    public class UpdateClientUseCase : IUpdateClientUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUpdateOutputPort _outputHandler;

        public UpdateClientUseCase(IClientRepository clientRepository, IUpdateOutputPort outputHandler)
        {
            _clientRepository = clientRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(int id, CreateClientInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            var client = new User(){
                Name = input.Name,
                Surname = input.Surname,
                PhoneNumber = input.PhoneNumber,
                Email = input.Email
            };
            await _clientRepository.Update(id, client);
            var createClientOutput = new CreateClientOutput(client.Name, client.Surname, client.PhoneNumber, client.Email);
            _outputHandler.Standard(createClientOutput);
        }
    }
}