﻿namespace EasyControl.Dominio.Pessoa._1.Entidade
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

        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public string Rg { get; protected set; }
        public string Cpf { get; protected set; }
    }
}
