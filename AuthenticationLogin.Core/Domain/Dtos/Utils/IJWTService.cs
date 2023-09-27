using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Core.Domain.Dtos.Utils
{
    public interface IJWTService
    {
        string GenerateToken(string username);
    }
}
