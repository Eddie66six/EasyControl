using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Medico.Entidade;
using System.Collections.Generic;

namespace EasyControl.Dominio.Empresa.Entidade
{
    public class Filial
    {
        protected Filial()
        {
            Colaboradores = new List<Colaborador>();
            Medicos = new List<Medico>();
        }

        public Filial(string nome)
        {
            Colaboradores = new List<Colaborador>();
            Medicos = new List<Medico>();
            Nome = nome;
        }
        public int IdFilial { get; private set; }
        public string Nome { get; private set; }
        public int IdEmpresa { get; private set; }
        public Empresa Empresa { get; private set; }
        public IEnumerable<Colaborador> Colaboradores { get; private set; }
        public IEnumerable<Medico> Medicos { get; private set; }
    }
}
