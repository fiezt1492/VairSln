using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Vair.Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole() { }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }

        public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new HashSet<ApplicationUserRole>();
    }
}
