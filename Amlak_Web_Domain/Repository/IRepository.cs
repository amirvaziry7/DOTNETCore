using Amlak_Web_Domain.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.Repository
{
    public interface IRepository<T> where T :ModificationBaseEntity
    {
        List<T> Gets();
        T Get(Expression<Func<T, bool>> expression);
        void Insert(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
