using EasyControl.Dominio.Pessoa.Funcionario._2.Enum;

namespace EasyControl.Dominio.Pessoa.Funcionario._1.Entidade
{
    public class Funcionario : Pessoa._1.Entidade.Pessoa
    {
        protected Funcionario()
        {
        }

        protected Funcionario(ETipoFuncionario tipo, string nome, string sobrenome, string rg, string cpf) :base(nome,sobrenome,rg,cpf)
        {
            Tipo = tipo;
        }

        protected ETipoFuncionario Tipo { get; }
    }
}
