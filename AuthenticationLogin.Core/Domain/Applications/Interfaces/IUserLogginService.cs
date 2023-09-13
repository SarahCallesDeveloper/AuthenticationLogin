using AuthenticationLogin.Core.Domain.Dtos.JWT;
using AuthenticationLogin.Core.Domain.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Core.Domain.Applications.Interfaces
{
    public interface IUserLogginService
    {
        bool UserLogging(UserLogginRequest userLogginData);
    }
}
