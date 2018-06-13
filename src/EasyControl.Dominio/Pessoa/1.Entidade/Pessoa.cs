namespace EasyControl.Dominio.Pessoa._1.Entidade
{
    public class Pessoa
    {
        protected Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome, string rg, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Rg = rg;
            Cpf = cpf;
        }

        public string GetNomeCompleto()
        {
            return Nome + (!string.IsNullOrEmpty(Sobrenome) ? " " + Sobrenome : "");
        }

        protected string Nome { get; set; }
        protected string Sobrenome { get; set; }
        protected string Rg { get; set; }
        protected string Cpf { get; set; }
    }
}
