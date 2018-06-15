using System;
using System.Linq;
using EasyControl.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EasyControl.Repositorio.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected readonly DbSet<T> DbSet;
        protected Contexto Db => _gerenciadorContexto.GetContext();
        protected readonly GerenciadorContexto _gerenciadorContexto;
        public BaseRepositorio(GerenciadorContexto gerenciadorContexto)
        {
            _gerenciadorContexto = gerenciadorContexto;
            DbSet = Db.Set<T>();
        }

        public void Add(T obj)
        {
            DbSet.Add(obj);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Update(T obj)
        {
            DbSet.Update(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
