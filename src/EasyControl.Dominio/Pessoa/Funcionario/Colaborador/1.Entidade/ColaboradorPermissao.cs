using EasyControl.Dominio.Pessoa.Funcionario._1.Entidade;

namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador._1.Entidade
{
    public class ColaboradorPermissao
    {
        public int IdColaborador { get; set; }
        public Colaborador Colaborador { get; set; }
        public int IdPermissao { get; set; }
        public Permissao Permissao { get; set; }
    }
}