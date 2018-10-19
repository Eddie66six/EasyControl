using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using EasyControl.Dominio;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Model;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Repositorio;
using EasyControl.Servico.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EasyControl.Servico.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IColaboradorRepositorio _colaboradorRepositorio;
        public LoginController(IUnitOfWork unitOfWork, IColaboradorRepositorio colaboradorRepositorio)
        {
            _unitOfWork = unitOfWork;
            _colaboradorRepositorio = colaboradorRepositorio;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("colaborador")]
        public object Post(
            [FromBody]LoginModel usuario,
            [FromServices]SigningConfigurations signingConfigurations,
            [FromServices]TokenConfigurations tokenConfigurations)
        {
            LoginColaboradorModel usuarioDb = null;
            if (!string.IsNullOrWhiteSpace(usuario.Usuario) && !string.IsNullOrEmpty(usuario.Senha))
            {
                usuarioDb = _colaboradorRepositorio.Logar(usuario.Usuario, usuario.Senha);
            }

            if (usuarioDb != null)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(usuarioDb.IdColaborador.ToString(), "Login"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, usuarioDb.IdColaborador.ToString())
                    }
                );

                DateTime dataCriacao = DateTime.UtcNow;
                DateTime dataExpiracao = dataCriacao +
                    TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();

                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK"
                };
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Falha ao autenticar"
                };
            }
        }
    }
}