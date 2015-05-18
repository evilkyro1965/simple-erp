using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace simpleerp.model
{
    [Table("InventoryItem")]
    public class InventoryItem:LookupEntity
    {
        public string Code { get; set; }
        public InventoryCategory Category { get; set; }
        public InventoryUOM UOM { get; set; }
        public InventoryType Type { get; set; }
    }
}
