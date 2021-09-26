using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.BaseEntity.Modification
{
    public interface IModificationBaseEntity
    {
        DateTime InsertDate { get; set; } 
        DateTime UpdateTime { get; set; }
        bool IsRemoved { get; set; }
    }
}
