using Amlak_Web_Domain.Entity.Ground;
using Amlak_Web_Domain.Entity.Owner;
using Amlak_Web_Domain.Repository;
using Amlak_Web_Persistence.Services.Contraction;
using Amlak_Web_Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Persistence.Services.UnitOfWork
{
    public class UnitOfWork : IUnitOfWrork
    {
        DataBaseContext Db;
        IRepository<Ground> _ground;
        IRepository<Owner> _owner;
        public UnitOfWork(DataBaseContext _db)
        {
            this.Db = _db;
        }

        public IRepository<Ground> Ground
        {
            get
            {
                if (_ground == null)
                    _ground = new Repository<Ground>(Db);
                return _ground;
            }
        }

        public IRepository<Owner> Owner
        {
            get
            {
                if (_owner == null)
                    _owner = new Repository<Owner>(Db);
                return _owner;
            }
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
