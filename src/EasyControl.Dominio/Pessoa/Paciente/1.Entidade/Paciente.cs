namespace EasyControl.Dominio.Pessoa.Paciente._1.Entidade
{
    public class Paciente : Pessoa._1.Entidade.Pessoa
    {
        protected Paciente()
        {

        }

        public Paciente(string nome, string sobrenome, string rg, string cpf) : base(nome, sobrenome, rg, cpf)
        {

        }

        public Convenio._1.Entidade.Convenio Convenio { get; set; }
    }
}
