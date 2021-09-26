using Amlak_Web_Domain.BaseEntity.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.Abstract_Class
{
    public abstract class IdentityBaseEntity : ModificationBaseEntity, IIdentityBaseEntity
    {
        public int ID { get ; set ; }
    }
}
