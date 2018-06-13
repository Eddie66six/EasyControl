using System.Collections.Generic;
using System.Linq;

namespace EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade
{
    public class Medico : Funcionario._1.Entidade.Funcionario
    {
        protected Medico()
        {
            Especialidades = new List<Especialidade>();
            ConveniosCredenciados = new List<Convenio._1.Entidade.Convenio>();
        }

        public Medico(string nome, string sobrenome, string rg, string cpf):base(_2.Enum.ETipoFuncionario.Medico, nome,sobrenome,rg,cpf)
        {
            ConveniosCredenciados = new List<Convenio._1.Entidade.Convenio>();
            Especialidades = new List<Especialidade>();
        }

        public void AddEspecialidades(Especialidade[] especialidades)
        {
            Especialidades.ToList().AddRange(especialidades ?? new Especialidade[0]);
        }

        public IEnumerable<Especialidade> Especialidades { get; }
        public IEnumerable<Convenio._1.Entidade.Convenio> ConveniosCredenciados { get; set; }
    }
}
