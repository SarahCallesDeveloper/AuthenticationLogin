using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Core.Domain.Dtos.Request
{
    public class UserLogginRequest
    {
        [FromBody]
        public string Username { get; set; }
        [FromBody]
        public string Password { get; set; }

    }
}
