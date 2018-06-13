using System.Collections.Generic;

namespace EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade
{
    public class Especialidade
    {
        protected Especialidade()
        {
            Procedimentos = new List<Procedimento>();
        }

        public Especialidade(string nome)
        {
            Procedimentos = new List<Procedimento>();
            Nome = nome;
        }

        public int IdEspecialidade { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Procedimento> Procedimentos { get; set; }
    }
}
