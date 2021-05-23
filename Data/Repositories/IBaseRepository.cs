using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Data.Repositories
{
    public interface IBaseRepository<T> where T:class
    {
        public IQueryable<T> FindAll();
        public bool Create(T entity);
        public void UPdate(T entity);
        public bool Delete(T entity);
    }
}
