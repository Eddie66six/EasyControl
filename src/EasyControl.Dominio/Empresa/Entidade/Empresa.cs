using EasyControl.Dominio.Pessoa.Paciente.Entidade;
using System.Collections.Generic;

namespace EasyControl.Dominio.Empresa.Entidade
{
    public class Empresa
    {
        protected Empresa()
        {
            Filiais = new List<Filial>();
            Pacientes = new List<Paciente>();
            Convenios = new List<Convenio.Entidade.Convenio>();
        }

        public Empresa(string nome)
        {
            Filiais = new List<Filial>();
            Pacientes = new List<Paciente>();
            Convenios = new List<Convenio.Entidade.Convenio>();
            Nome = nome;
        }
        public int IdEmpresa { get; private set; }
        public string Nome { get; private set; }
        public IEnumerable<Filial> Filiais { get; private set; }
        public IEnumerable<Paciente> Pacientes { get; private set; }
        public IEnumerable<Convenio.Entidade.Convenio> Convenios { get; private set; }
    }
}
