using AuthenticationLogin.Core.Domain.Applications.Interfaces;
using AuthenticationLogin.Core.Domain.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Infraestructure.Services.Implementation
{
    public class UserLogginService : IUserLogginService
    {
        public bool UserLogging(UserLogginRequest userLogginData)
        {
            return true;
        }
    }
}
