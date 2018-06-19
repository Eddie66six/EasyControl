using EasyControl.Dominio;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Repositorio;
using EasyControl.Repositorio.Repositorio;
using EasyControl.Repositorio.Repositorio.Pessoa.Funcionario.Colaborador;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyControl.Repositorio
{
    public class Ioc
    {
        public static void RegisterServicesIoc(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<Contexto>();
            services.AddTransient<GerenciadorContexto>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IColaboradorRepositorio, ColaboradorRepositorio>();
            services.Configure<Appsettings>(configuration.GetSection("AppSettings"));
        }
    }
}
