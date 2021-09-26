using Amlak_Web_Domain.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Domain.Entity.Owner
{
    public class Owner:IdentityBaseEntity
    {
        public string FullName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public List<Ground.Ground> Ground { get; set; }
    }
}
