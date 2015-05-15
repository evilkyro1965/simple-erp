using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleerp.model
{
    public class InventoryItem:LookupEntity
    {
        public string Code { get; set; }
        public InventoryCategory Category { get; set; }
        public InventoryUOM UOM { get; set; }
        public InventoryType Type { get; set; }
    }
}
