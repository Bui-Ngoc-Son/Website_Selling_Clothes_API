using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public virtual List<CartDetails> Details { get; set; }
    }
}
