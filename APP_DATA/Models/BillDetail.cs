using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class BillDetail
    {
        [Key]
        public Guid ID { get; set; }
        public double Price { get; set; }
        public string Voucher { get; set; }
        public string ProductID { get; set; }
        public string BillID { get; set; }
    }
}
