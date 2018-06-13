namespace EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade
{
    public class Procedimento
    {
        protected Procedimento()
        {
            
        }

        protected Procedimento(string nome)
        {
            Nome = nome;
        }

        public int IdProcedimento { get; set; }
        public string Nome { get; set; }
        public int IdEspecialidade { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
