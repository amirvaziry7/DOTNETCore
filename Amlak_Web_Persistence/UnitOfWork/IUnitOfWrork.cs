using Amlak_Web_Domain.Entity.Ground;
using Amlak_Web_Domain.Entity.Owner;
using Amlak_Web_Domain.Repository;
using Amlak_Web_Persistence.Services.Contraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Persistence.UnitOfWork
{
    public interface IUnitOfWrork : IDisposable
    {

        IRepository<Ground> Ground { get; }
        IRepository<Owner> Owner { get; }
        int SaveChanges();
    }
}
