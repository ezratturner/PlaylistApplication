using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PlaylistWeb.Data;
using PlaylistWeb.Interfaces;

namespace PlaylistWeb.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        public Repository(ApplicationDbContext repositoryContext)
        {
            RepositoryContext = RepositoryContext;
        }
         
        public T Create(T entity)
        {
            return RepositoryContext.Set<T>().Add(entity).Entity;
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
