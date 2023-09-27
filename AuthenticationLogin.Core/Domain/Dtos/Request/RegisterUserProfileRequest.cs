using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLogin.Core.Domain.Dtos.Request
{
    public class RegisterUserProfileRequest
    {
        [FromBody]
        public string Username { get; set; }
        [FromBody]
        public string Password { get; set; }
        [FromBody]
        public string Name { get; set; }
        [FromBody]
        public string LastName { get; set; }
        [FromBody]
        public int PhoneNumber { get; set; }


    }
}
