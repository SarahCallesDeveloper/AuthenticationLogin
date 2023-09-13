using AuthenticationLogin.Core.Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Core.Domain.Applications.Interfaces
{
    public interface IUserDataRetrieverService
    {
        RetrieveUserDataResponse RetriveUserData();
    }
}
