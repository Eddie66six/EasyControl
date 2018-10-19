using EasyControl.Dominio;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace EasyControl.Servico.Controllers.Pessoa.Funcionario.Colaborador
{
    [Route("api/[controller]")]
    public class ColaboradorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IColaboradorRepositorio _colaboradorRepositorio;
        public ColaboradorController(IUnitOfWork unitOfWork, IColaboradorRepositorio colaboradorRepositorio)
        {
            _unitOfWork = unitOfWork;
            _colaboradorRepositorio = colaboradorRepositorio;
        }
    }
}
