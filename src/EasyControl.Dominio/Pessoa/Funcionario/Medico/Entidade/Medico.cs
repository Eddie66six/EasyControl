using EasyControl.Dominio.Empresa.Entidade;
using System.Collections.Generic;
using System.Linq;

namespace EasyControl.Dominio.Pessoa.Funcionario.Medico.Entidade
{
    public class Medico : Funcionario.Entidade.Funcionario
    {
        protected Medico()
        {
            Especialidades = new List<Especialidade>();
            ConveniosCredenciados = new List<ConvenioCredenciado>();
        }

        public Medico(string nome, string sobrenome, string rg, string cpf):base(nome,sobrenome,rg,cpf)
        {
            ConveniosCredenciados = new List<ConvenioCredenciado>();
            Especialidades = new List<Especialidade>();
        }

        public void AddEspecialidades(Especialidade[] especialidades)
        {
            Especialidades.ToList().AddRange(especialidades ?? new Especialidade[0]);
        }

        public int IdMedico { get; set; }
        public IEnumerable<Especialidade> Especialidades { get; private set; }
        public IEnumerable<ConvenioCredenciado> ConveniosCredenciados { get; private set; }
        public int IdFilial { get; private set; }
        public Filial Filial { get; private set; }
    }
}
