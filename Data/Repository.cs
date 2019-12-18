using System.Collections.Generic;
using appWebApi.Domain;
using System.Linq;
using System;

namespace appWebApi.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ContextDB _context;
        public Repository(ContextDB context)
        {
            _context = context;
        }

        public bool CreatePost(T entity)
        {
            entity.CriadoEm = DateTime.UtcNow;
            entity.AtualizadoEm = DateTime.UtcNow;
            _context.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetId(long id)
        {
            return _context.Set<T>().Single(e => e.Id == id);
        }

        public bool Update(T entity)
        {
            var e = _context.Set<T>().Single(x => x.Id == entity.Id);
            entity.AtualizadoEm = DateTime.UtcNow;
            e = entity;
            _context.Set<T>().Update(e);
            return true;
        }
    }
}
