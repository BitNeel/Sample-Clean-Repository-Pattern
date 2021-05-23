using BlogPosts.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Data.Repositories
{
    public class BaseRepository<T>:IBaseRepository<T> where T:class
    {
        private readonly TEST1Context _dbContext;
        public BaseRepository(TEST1Context tcn)
        {
            _dbContext = tcn;
        }

        public bool Create(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public void UPdate(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
