using System.Collections.Generic;
using System.Linq;
using EasyControl.Dominio.Pessoa.Funcionario._2.Enum;

namespace EasyControl.Dominio.Pessoa.Funcionario._1.Entidade
{
    public class Funcionario : Pessoa._1.Entidade.Pessoa
    {
        protected Funcionario()
        {
            Permissoes = new List<Permissao>();
        }

        protected Funcionario(ETipoFuncionario tipo, string nome, string sobrenome, string rg, string cpf) :base(nome,sobrenome,rg,cpf)
        {
            Permissoes = new List<Permissao>();
            Tipo = tipo;
        }

        public void AddPermissoes(Permissao[] permissaos)
        {
            Permissoes.ToList().AddRange(permissaos ?? new Permissao[0]);
        }

        protected int IdFuncionario { get; set; }
        protected ETipoFuncionario Tipo { get; }
        protected IEnumerable<Permissao> Permissoes { get; set; }
    }
}
