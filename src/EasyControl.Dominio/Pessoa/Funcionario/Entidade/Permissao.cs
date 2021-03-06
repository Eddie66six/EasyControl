﻿using System.Collections.Generic;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Entidade;

namespace EasyControl.Dominio.Pessoa.Funcionario.Entidade
{
    public class Permissao
    {
        protected Permissao()
        {
            Colaboradores = new List<ColaboradorPermissao>();
        }

        public Permissao(string key)
        {
            Key = key;
            Colaboradores = new List<ColaboradorPermissao>();
        }

        public int IdPermissao { get; set; }
        public string Key { get; set; }
        public int IdFuncionario { get; set; }
        public IEnumerable<ColaboradorPermissao> Colaboradores { get; set; }
    }
}
