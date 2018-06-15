using System.Collections.Generic;
using System.Linq;
using EasyControl.Dominio.Pessoa.Funcionario._2.Enum;

namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador._1.Entidade
{
    public class Colaborador : Funcionario._1.Entidade.Funcionario
    {
        protected Colaborador()
        {
            Permissoes = new List<ColaboradorPermissao>();
        }

        public Colaborador(string nome, string sobrenome, string rg, string cpf) : base(ETipoFuncionario.Colaborador, nome, sobrenome, rg, cpf)
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
    }
}
