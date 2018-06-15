namespace EasyControl.Dominio.Pessoa.Funcionario.Entidade
{
    public class Funcionario : Pessoa
    {
        protected Funcionario()
        {
        }

        protected Funcionario(string nome, string sobrenome, string rg, string cpf) :base(nome,sobrenome,rg,cpf)
        {
        }
    }
}
