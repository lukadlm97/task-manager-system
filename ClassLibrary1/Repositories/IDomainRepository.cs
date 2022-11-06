using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IDomainRepository<T>
    where T : class
    {
        Task<T> GetById(int id);
        Task<IQueryable<T>> GetAll();
        Task Delete(int id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);

    }
}
