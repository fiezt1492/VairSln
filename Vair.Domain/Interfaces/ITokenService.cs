using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vair.Domain.Entities;

namespace Vair.Domain.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(ApplicationUser user);
        DateTime GetExpireDate(string token);
    }
}
