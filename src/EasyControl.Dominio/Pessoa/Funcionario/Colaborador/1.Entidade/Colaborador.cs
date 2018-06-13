namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador._1.Entidade
{
    public class Colaborador : Funcionario._1.Entidade.Funcionario
    {
        protected Colaborador()
        {

        }

        public Colaborador(string nome, string sobrenome, string rg, string cpf) : base(_2.Enum.ETipoFuncionario.Colaborador, nome, sobrenome, rg, cpf)
        {

        }
    }
}
