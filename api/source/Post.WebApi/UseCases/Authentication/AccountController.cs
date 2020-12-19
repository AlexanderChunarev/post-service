using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Post.Application.Boundaries.Authentication;
using Post.Application.UseCases.Authentication;

namespace Post.WebApi.UseCases.Authentication
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAuthenticationUserUseCase _authenticationUserUseCase;
        private readonly AuthenticationPresenter _authenticationPresenter;

        public AccountController(IAuthenticationUserUseCase authenticationUserUseCase, AuthenticationPresenter authenticationPresenter)
        {
            _authenticationUserUseCase = authenticationUserUseCase;
            _authenticationPresenter = authenticationPresenter;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticationInput input)
        {
            await _authenticationUserUseCase.Execute(input);
            return _authenticationPresenter.ViewModel;
        }
        
        [Authorize]
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok("Success");
        }
    }
}