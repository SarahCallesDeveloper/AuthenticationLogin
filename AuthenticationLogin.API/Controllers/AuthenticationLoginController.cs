using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthenticationLogin.Core;
using AuthenticationLogin.Core.Domain.Dtos.Request;
using AuthenticationLogin.Core.Domain.Applications.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using AuthenticationLogin.Core.Domain.Dtos.Response;
using AuthenticationLogin.Infraestructure.Utils;
using AuthenticationLogin.Core.Domain.Dtos.Utils;
//using AutoMapper;
using AuthenticationLogin.Core.Domain.Dtos.JWT;

namespace AuthenticationLogin.API.Controllers
{
    
    [ApiController]
    public class AuthenticationLoginController : ControllerBase
    {
        private readonly IProfileRegistrationService _profileRegistrationService;
        private readonly IUserDataRetrieverService _userDataRetrieverService;
        private readonly IUserLogginService _userLogginService;
        private readonly IJWTService _jwtService;
       // private readonly IMapper _mapper;

        public AuthenticationLoginController(IProfileRegistrationService profileRegistrationService, IUserDataRetrieverService UserDataRetrieverService, IUserLogginService UserLogginService, IJWTService jWTService)
        {
            _profileRegistrationService = profileRegistrationService;
            _userDataRetrieverService = UserDataRetrieverService;   
            _userLogginService = UserLogginService;
            _jwtService = jWTService;
          //  _mapper = mapper;

        }

        [HttpPost("api/createAccount/")]
        public IActionResult CreateAccount([FromBody]RegisterUserProfileRequest UserProfileData) {

            bool accountCreationIsSuccesful = _profileRegistrationService.RegisterUserProfile(UserProfileData);
            if (accountCreationIsSuccesful == true)
            {
                return Ok("User registration succesful");
            }
            else { return BadRequest(); }
        }



        [HttpPost("api/Login/")]
        public IActionResult Login(UserLogginRequest userLoginData)
        {
            var username = userLoginData.Username;
            bool accountLogginIsSuccesful = _userLogginService.UserLogging(userLoginData);
            if (accountLogginIsSuccesful == true)
            {
                string token = _jwtService.GenerateToken(username);
               return Ok(new { message = "UserLogin successful", token });
            }
            else { return BadRequest(); }
        }
        [Authorize]
        [HttpGet("api/RetrieveData/")]
        public IActionResult retrieveData()
        {
           RetrieveUserDataResponse userData = _userDataRetrieverService.RetriveUserData();
            return Ok(userData);
        }

    }
}
