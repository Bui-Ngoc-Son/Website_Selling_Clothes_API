using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Voucher
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Account Account { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
