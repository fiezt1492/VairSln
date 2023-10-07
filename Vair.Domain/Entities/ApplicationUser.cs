using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vair.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; } = string.Empty;

        public virtual ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new HashSet<ApplicationUserRole>();

    }
}
