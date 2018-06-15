namespace EasyControl.Dominio.Pessoa.Paciente.Entidade
{
    public class Paciente : Pessoa
    {
        protected Paciente()
        {

        }

        public Paciente(string nome, string sobrenome, string rg, string cpf) : base(nome, sobrenome, rg, cpf)
        {

        }

        public int IdPaciente { get; private set; }
        public Convenio.Entidade.Convenio Convenio { get; private set; }
        public int IdEmpresa { get; private set; }
        public Empresa.Entidade.Empresa Empresa { get; private set; }
    }
}
