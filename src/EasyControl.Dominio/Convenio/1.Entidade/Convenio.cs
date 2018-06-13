using System.Collections.Generic;
using EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade;
using EasyControl.Dominio.Pessoa.Paciente._1.Entidade;

namespace EasyControl.Dominio.Convenio._1.Entidade
{
    public class Convenio
    {
        protected Convenio()
        {
            Pacientes = new List<Paciente>();
            MedicosCredenciados = new List<Medico>();
        }

        public Convenio(string nome)
        {
            Pacientes = new List<Paciente>();
            MedicosCredenciados = new List<Medico>();
            Nome = nome;
        }

        public int IdConvenio { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Paciente> Pacientes { get; set; }
        public IEnumerable<Medico> MedicosCredenciados { get; set; }
    }
}
