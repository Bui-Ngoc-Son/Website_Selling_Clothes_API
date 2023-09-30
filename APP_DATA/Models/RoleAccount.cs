using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class RoleAccount
    {
        [Key]
        public Guid Id { get; set; }
        public string RoleName { get; set; }
    }
}
