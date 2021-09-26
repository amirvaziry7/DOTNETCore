using Amlak_Web_Domain.Abstract_Class;
using Amlak_Web_Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Persistence.Services.Contraction
{
    public class Repository<T> : IRepository<T> where T : ModificationBaseEntity
    {
        public DataBaseContext DB;
        public DbSet<T> dbset;
        public Repository(DataBaseContext db)
        {
            DB = db;
            dbset = DB.Set<T>();
        }
        public void Delete(T Entity)
        {
            Entity.IsRemoved = true;
        }

        public T Get(Expression<Func<T, bool>> expression)
        => dbset.Where(expression).FirstOrDefault();

        public List<T> Gets()
        => dbset.ToList();

        public void Insert(T Entity)
        {
            dbset.Add(Entity);
        }

        public void Update(T Entity)
        {
            DB.Entry(dbset).State = EntityState.Modified;
        }
    }
}
