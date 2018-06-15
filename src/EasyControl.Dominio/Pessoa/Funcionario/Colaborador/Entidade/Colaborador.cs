using EasyControl.Dominio.Empresa.Entidade;
using System.Collections.Generic;
using System.Linq;

namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Entidade
{
    public class Colaborador : Funcionario.Entidade.Funcionario
    {
        protected Colaborador()
        {
            Permissoes = new List<ColaboradorPermissao>();
        }

        public Colaborador(string nome, string sobrenome, string rg, string cpf) : base(nome, sobrenome, rg, cpf)
        {
            Permissoes = new List<ColaboradorPermissao>();
        }

        public void AddPermissoes(int[] permissaos)
        {
            if (permissaos == null || !permissaos.Any()) return;
            Permissoes.ToList().AddRange(permissaos.Select(p => new ColaboradorPermissao { IdColaborador = IdColaborador, IdPermissao = p }));
        }

        public int IdColaborador { get; set; }
        public IEnumerable<ColaboradorPermissao> Permissoes { get; protected set; }
        public int IdFilial { get; set; }
        public Filial Filial { get; set; }
    }
}
