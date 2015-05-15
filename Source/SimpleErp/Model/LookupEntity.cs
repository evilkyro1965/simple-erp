using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleerp.model
{
    public abstract class LookupEntity:IdentifiableEntity
    {
        public string Name { get; set; }
    }
}
