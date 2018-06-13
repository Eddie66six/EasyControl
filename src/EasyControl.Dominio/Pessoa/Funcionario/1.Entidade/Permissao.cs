using System.Collections.Generic;

namespace EasyControl.Dominio.Pessoa.Funcionario._1.Entidade
{
    public class Permissao
    {
        protected Permissao()
        {
            Funcionario = new List<Funcionario>();
        }

        public Permissao(string key)
        {
            Key = key;
            Funcionario = new List<Funcionario>();
        }

        public int IdPermissao { get; set; }
        public string Key { get; set; }
        public int IdFuncionario { get; set; }
        public IEnumerable<Funcionario> Funcionario { get; set; }
    }
}
