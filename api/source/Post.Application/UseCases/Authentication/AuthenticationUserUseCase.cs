using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Post.Application.Boundaries.Authentication;
using Post.Application.Repositories.Client;
using Post.Application.Utils;

namespace Post.Application.UseCases.Authentication
{
    using Domain.User;

    public class AuthenticationUserUseCase : IAuthenticationUserUseCase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IOutputPort _outputHandler;

        public AuthenticationUserUseCase(IClientRepository clientRepository, IOutputPort outputHandler)
        {
            _clientRepository = clientRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(AuthenticationInput input)
        {
            var client = await _clientRepository.GetUserByCredentials(
                input.Login,
                CryptUtils.EncryptPassword(input.Password)
            );

            if (client == null) return;
            
            _outputHandler.Standard(new AuthenticationOutput(
                client.Id,
                client.Name,
                client.Surname,
                client.Email,
                ""));
        }
    }
}