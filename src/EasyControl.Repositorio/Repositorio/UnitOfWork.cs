using EasyControl.Dominio;

namespace EasyControl.Repositorio.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GerenciadorContexto _gerenciadorContexto;
        private Contexto _context => _gerenciadorContexto.GetContext();
        public UnitOfWork(GerenciadorContexto gerenciadorContexto)
        {
            _gerenciadorContexto = gerenciadorContexto;
        }

        public bool Commit()
        {
            try
            {
                _context.SaveChanges();
                Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
