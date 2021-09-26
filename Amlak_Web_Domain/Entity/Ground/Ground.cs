using Amlak_Web_Domain.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.Entity.Ground
{
    public class Ground : IdentityBaseEntity
    {
        public int OwnerID { get; set; }
        public string Title { get; set; }
        public int Area { get; set; }
        public string Address { get; set; }
        public string Possition { get; set; }
        public Owner.Owner Owner { get; set; }
    }
}
