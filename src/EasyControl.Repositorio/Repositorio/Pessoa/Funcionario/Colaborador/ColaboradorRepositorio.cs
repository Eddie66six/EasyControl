using System.Data.SqlClient;
using System.Linq;
using Dapper;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Repositorio;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Model;
using Microsoft.Extensions.Options;

namespace EasyControl.Repositorio.Repositorio.Pessoa.Funcionario.Colaborador
{
    public class ColaboradorRepositorio : BaseRepositorio<Dominio.Pessoa.Funcionario.Colaborador.Entidade.Colaborador>, IColaboradorRepositorio
    {
        private readonly Appsettings _appsettings;
        public ColaboradorRepositorio(GerenciadorContexto context, IOptions<Appsettings> appsettings) : base(context)
        {
            _appsettings = appsettings.Value;
        }

        public LoginColaboradorModel Logar(string usuario, string senha)
        {
            using (SqlConnection conexao = new SqlConnection(
                _appsettings.ConnectionStrings.Dapper))
            {
                return conexao.QueryFirstOrDefault<LoginColaboradorModel>("SELECT c.IdColaborador,c.Nome FROM dbo.Colaboradores c where c.Usuario = @usuario and c.Senha = @senha", new {usuario = usuario, senha = senha});
            }
        }
    }
}
