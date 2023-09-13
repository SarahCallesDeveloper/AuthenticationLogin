using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Core.Domain.Dtos.Response
{
    public class RetrieveUserDataResponse
    {
        public string User { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }



    }
}
