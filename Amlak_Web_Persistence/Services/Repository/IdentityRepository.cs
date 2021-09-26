using Amlak_Web_Domain.Abstract_Class;
using Amlak_Web_Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Persistence.Services.Contraction
{
    public class IdentityRepository<T> : Repository<T>, IIdentityRepository<T> where T :IdentityBaseEntity
    {
        public IdentityRepository(DataBaseContext db):base(db)
        {

        }
        public void Delete(int ID)
        {
            T Entity = Get(ID);
            Delete(Entity);
        }

        public T Get(int ID)
       => dbset.Find(ID);
    }
}
