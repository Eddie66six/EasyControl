using System.Collections.Generic;
using System.Linq;

namespace EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade
{
    public class Medico : Funcionario._1.Entidade.Funcionario
    {
        protected Medico()
        {
            Especialidades = new List<Especialidade>();
            ConveniosCredenciados = new List<ConvenioCredenciado>();
        }

        public Medico(string nome, string sobrenome, string rg, string cpf):base(_2.Enum.ETipoFuncionario.Medico, nome,sobrenome,rg,cpf)
        {
            ConveniosCredenciados = new List<ConvenioCredenciado>();
            Especialidades = new List<Especialidade>();
        }

        public void AddEspecialidades(Especialidade[] especialidades)
        {
            Especialidades.ToList().AddRange(especialidades ?? new Especialidade[0]);
        }

        public int IdMedico { get; set; }
        public IEnumerable<Especialidade> Especialidades { get; }
        public IEnumerable<ConvenioCredenciado> ConveniosCredenciados { get; set; }
    }
}
