namespace EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade
{
    public class ConvenioCredenciado
    {
        public int IdMedico { get; set; }
        public Medico Medico { get; set; }
        public int IdConveio { get; set; }
        public Convenio._1.Entidade.Convenio Convenio { get; set; }
    }
}
