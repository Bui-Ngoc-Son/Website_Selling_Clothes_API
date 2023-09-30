using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Password { get; set; }
        public string RoleAccountID { get; set; }

    }
}
