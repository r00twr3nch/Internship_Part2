using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminUsername { get; set; }
        public string Password { get; set; }
        public string AdminPassword { get; set; }
        // Navigation properties can be added if needed, e.g., for roles or permissions
        // public virtual List<Role> Roles { get; set; }
        // public virtual List<Permission> Permissions { get; set; }
    }
}
