using EasyControl.Dominio.Pessoa.Funcionario.Colaborador._3.Model;

namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador._2.Repositorio
{
    public interface IColaboradorRepositorio : IBaseRepositorio<_1.Entidade.Colaborador>
    {
        LoginColaboradorModel Logar(string usuario, string senha);
    }
}