using Amlak_Web_Domain.BaseEntity.Modification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.Abstract_Class
{
    public abstract class ModificationBaseEntity : IModificationBaseEntity
    {
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get ; set; }
        public bool IsRemoved { get; set ; }
    }
}
