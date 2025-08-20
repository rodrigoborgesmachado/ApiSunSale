using ApiSunSale.Presentation.Api.Handler;
using ApiSunSale.Application.Interfaces;
using ApiSunSale.Domain.ModelClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using ApiSunSale.Presentation.Model.Requests;
using Amazon.Runtime;

namespace ApiSunSale.Presentation.Api.Controllers
{
    [ApiController]
    [Route("token")]
    [Authorize]
    public class TokenController : IDisposable
    {
        private readonly IConfiguration _builder;
        private readonly IUsuariosAppService _usuariosAppService;
        private readonly ILoggerAppService _loggerAppService;
        private readonly Settings _settings;
        private readonly TokenHandler _tokenHandler;

        public TokenController(IConfiguration builder, ILoggerAppService loggerAppService, IOptions<Settings> settings, IHttpContextAccessor httpContextAccessor, IUsuariosAppService usuariosAppService)
        {
            _builder = builder;
            _loggerAppService = loggerAppService;
            _settings = settings.Value;
            _tokenHandler = new TokenHandler(httpContextAccessor);
            _usuariosAppService = usuariosAppService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IResult> TokenAsync(TokenRequest request)
        {
            var result = await _usuariosAppService.GetByEmailAsync(request.Email);

            if (result == null)
            {
                return Results.Unauthorized();
            }

            if (result.IsActive != 1 || result.IsDeleted == 1)
            {
                return Results.Json(new
                {
                    code = 402,
                    message = "Usuário não está ativo"
                });
            }

            if(!result.Pass.Equals(request.Password)) 
            { 
                return Results.Json(new {
                    code = 401,
                    message = "Senha incorreta!" 
                }); 
            }

            var claims = new[]
            {
                new Claim("Id", result.Id.ToString()),
                new Claim("Email", result.Email),
                new Claim("Name", result.Nome),
                new Claim("UserName", result.Email),
                new Claim("IsAdmin", result.Admin)
            };

            Token token = _tokenHandler.CreateToken(claims, _builder);
            return Results.Ok(token);
        }

        public void Dispose()
        {
            _loggerAppService.Dispose();
        }
    }
}
