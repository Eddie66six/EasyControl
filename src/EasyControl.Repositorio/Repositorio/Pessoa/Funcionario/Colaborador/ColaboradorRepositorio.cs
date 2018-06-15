using System.Linq;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Repositorio;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Model;

namespace EasyControl.Repositorio.Repositorio.Pessoa.Funcionario.Colaborador
{
    public class ColaboradorRepositorio : BaseRepositorio<Dominio.Pessoa.Funcionario.Colaborador.Entidade.Colaborador>, IColaboradorRepositorio
    {
        public ColaboradorRepositorio(GerenciadorContexto context) : base(context)
        {
        }

        public LoginColaboradorModel Logar(string usuario, string senha)
        {
            return Db.Colaboradores.Select(p=> new LoginColaboradorModel{ IdColaborador = p.IdColaborador, Nome = p.Nome}).FirstOrDefault();
        }
    }
}
