using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLogin.Core.Domain.Dtos.Utils;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AuthenticationLogin.Core.Domain.Dtos.JWT;

namespace AuthenticationLogin.Infraestructure.Utils
{
    public class JWTService : IJWTService
    {

        public  JWTConfiguration _JWTConfiguration;

        public JWTService (IOptions<JWTConfiguration> JWTConfiguration)
        {
            _JWTConfiguration = JWTConfiguration.Value;

        }

        public string GenerateToken(string username)
        {

            var key = _JWTConfiguration.SecretKey;
            var tokenKey = Encoding.ASCII.GetBytes(key);


            var tokenIdentifier = Guid.NewGuid().ToString();
            var tokenHandler = new JwtSecurityTokenHandler();


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim("tokenIdentifier", tokenIdentifier)
                }),
                Expires = DateTime.UtcNow.AddSeconds(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature),
                Audience = _JWTConfiguration.Audience,
                Issuer = _JWTConfiguration.Issuer,
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


    }
}
