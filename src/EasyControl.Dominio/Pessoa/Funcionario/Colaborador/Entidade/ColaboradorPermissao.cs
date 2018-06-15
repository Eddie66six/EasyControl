using EasyControl.Dominio.Pessoa.Funcionario.Entidade;

namespace EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Entidade
{
    public class ColaboradorPermissao
    {
        public int IdColaborador { get; set; }
        public Colaborador Colaborador { get; set; }
        public int IdPermissao { get; set; }
        public Permissao Permissao { get; set; }
    }
}