using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace simpleerp.model
{
    [Table("Vendor")]
    public class Vendor:LookupEntity
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string WebPageAddress { get; set;}
        public bool? IsActive { get; set; }
        public string Memo { get; set; }
        public virtual List<VendorContact> Contacts { get; set; }

        public Vendor()
        {
            Contacts = new List<VendorContact>();
        }

    }
}
