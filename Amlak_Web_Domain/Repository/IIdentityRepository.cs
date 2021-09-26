using Amlak_Web_Domain.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.Repository
{
    public interface IIdentityRepository<T> :IRepository<T> where T: IdentityBaseEntity
    {
        T Get(int ID);
        void Delete(int ID);
    }
}
