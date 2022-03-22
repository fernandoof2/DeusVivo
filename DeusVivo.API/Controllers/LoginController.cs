using DeusVivo.API.Auth;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
using DeusVivo.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DeusVivo.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IServiceUsuario _service;

        public LoginController(IServiceUsuario service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<dynamic> Autenticacao([FromBody] LoginViewModel login)
        {
            try
            {
                UsuarioEO usuario = new UsuarioEO() {
                    Login = login.Login,
                    Senha = login.Senha
                };

                var usuarioBanco = _service.GetUserLogin(usuario);

                if (usuarioBanco == null)
                    return NotFound(new { message = "Usuario e senha inválidos"});

                var token = TokenService.GenerateToken(usuarioBanco);

                usuarioBanco.Senha = "";

                return Ok(new
                {
                    user = usuarioBanco,
                    token = token
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
