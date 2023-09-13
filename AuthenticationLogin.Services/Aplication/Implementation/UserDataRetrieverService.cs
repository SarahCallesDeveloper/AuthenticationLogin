using AuthenticationLogin.Core.Domain.Applications.Interfaces;
using AuthenticationLogin.Core.Domain.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Infraestructure.Services.Implementation
{
    public class UserDataRetrieverService : IUserDataRetrieverService
    {
        public RetrieveUserDataResponse RetriveUserData()
        {
            RetrieveUserDataResponse userData = new RetrieveUserDataResponse();
            userData.User = "User";
            userData.PhoneNumber=123456789;
            userData.LastName = "LastName";
            userData.Password = "Password";
            userData.Name = "Name";
            return userData;
        }
    }
}
