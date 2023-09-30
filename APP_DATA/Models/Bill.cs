using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Bill
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Discount { get; set; }
        [Required]
        public string Description { get; set; }
        public string UserID { get; set; }
        public string VoucherID { get; set; }
    }
}
