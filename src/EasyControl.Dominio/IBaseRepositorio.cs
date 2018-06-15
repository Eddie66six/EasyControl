using System.Linq;

namespace EasyControl.Dominio
{
    public interface IBaseRepositorio<T> where T : class
    {
        void Add(T obj);
        T GetById(int id);
        IQueryable<T> GetAll();
        void Update(T obj);
        void Remove(int id);
        int SaveChanges();
    }
}