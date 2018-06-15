namespace EasyControl.Dominio.Pessoa.Funcionario.Medico.Entidade
{
    public class ConvenioCredenciado
    {
        public int IdMedico { get; set; }
        public Medico Medico { get; set; }
        public int IdConveio { get; set; }
        public Convenio.Entidade.Convenio Convenio { get; set; }
    }
}
