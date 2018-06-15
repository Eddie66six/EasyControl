using System.Collections.Generic;
using EasyControl.Dominio.Empresa.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Medico.Entidade;
using EasyControl.Dominio.Pessoa.Paciente.Entidade;

namespace EasyControl.Dominio.Convenio.Entidade
{
    public class Convenio
    {
        protected Convenio()
        {
            Pacientes = new List<Paciente>();
            MedicosCredenciados = new List<ConvenioCredenciado>();
        }

        public Convenio(string nome)
        {
            Pacientes = new List<Paciente>();
            MedicosCredenciados = new List<ConvenioCredenciado>();
            Nome = nome;
        }

        public int IdConvenio { get; private set; }
        public string Nome { get; private set; }
        public IEnumerable<Paciente> Pacientes { get; private set; }
        public IEnumerable<ConvenioCredenciado> MedicosCredenciados { get; private set; }
        public int IdFilial { get; private set; }
        public Empresa.Entidade.Empresa Empresa { get; private set; }
    }
}
