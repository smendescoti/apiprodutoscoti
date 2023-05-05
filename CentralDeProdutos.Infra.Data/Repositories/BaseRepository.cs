using CentralDeProdutos.Domain.Ports.Repositories;
using CentralDeProdutos.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Classe base dos repositórios
    /// </summary>
    public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        private readonly DataContext? _dataContext;

        protected BaseRepository(DataContext? dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual void Add(TEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            _dataContext.Remove(entity);
            _dataContext.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            return _dataContext.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(TKey id)
        {
            return _dataContext.Set<TEntity>().Find(id);
        }

        public virtual void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
