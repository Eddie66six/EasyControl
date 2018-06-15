using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Model;

namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Repositorio
{
    public interface IColaboradorRepositorio : IBaseRepositorio<Entidade.Colaborador>
    {
        LoginColaboradorModel Logar(string usuario, string senha);
    }
}