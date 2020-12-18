using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Post.Application.Boundaries.Authentication;
using Post.Application.Boundaries.Client;
using IOutputPort = Post.Application.Boundaries.Authentication.IOutputPort;

namespace Post.WebApi.UseCases.Authentication
{
    using Domain.Client;
    public sealed class AuthenticationPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        private readonly IConfiguration _configuration;

        public AuthenticationPresenter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Error(string message)
        {
            ViewModel = new JsonResult(message);
        }

        public void Standard(AuthenticationOutput output)
        {
            output.Token = GenerateJwtToken(output.Id);
            ViewModel = new JsonResult(output);
        }
        
        private string GenerateJwtToken(int clientId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {new Claim("id", clientId.ToString())}),
                Expires = DateTime.UtcNow.AddHours(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}