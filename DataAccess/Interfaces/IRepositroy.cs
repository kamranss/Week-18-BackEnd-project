using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepositroy<T> where T:IBaseInterface
    {
        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);

        T Get(Predicate<T> filter);
        List<T> GetAll(Predicate<T> filter);

        int Count();
    }
}
