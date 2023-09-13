using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthenticationLogin.Core;
using AuthenticationLogin.Core.Domain.Dtos.Request;
using AuthenticationLogin.Core.Domain.Applications.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using AuthenticationLogin.Core.Domain.Dtos.Response;

namespace AuthenticationLogin.API.Controllers
{
    
    [ApiController]
    public class AuthenticationLoginController : ControllerBase
    {
        private readonly IProfileRegistrationService _profileRegistrationService;
        private readonly IUserDataRetrieverService _userDataRetrieverService;
        private readonly IUserLogginService _userLogginService;

        public AuthenticationLoginController(IProfileRegistrationService profileRegistrationService, IUserDataRetrieverService UserDataRetrieverService, IUserLogginService UserLogginService)
        {
            _profileRegistrationService = profileRegistrationService;
            _userDataRetrieverService = UserDataRetrieverService;   
            _userLogginService = UserLogginService;
        }

        [HttpPost("api/createAccount/")]
        public IActionResult CreateAccount(RegisterUserProfileRequest UserProfileData) {

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

            bool accountLogginIsSuccesful = _userLogginService.UserLogging(userLoginData);
            if (accountLogginIsSuccesful == true)
            {
                return Ok("UserLogin succesful");
            }
            else { return BadRequest(); }
        }
        //[Authorize]
        [HttpGet("api/RetrieveData/")]
        public IActionResult retrieveData()
        {
           RetrieveUserDataResponse userData = _userDataRetrieverService.RetriveUserData();
            return Ok(userData);
        }

    }
}
