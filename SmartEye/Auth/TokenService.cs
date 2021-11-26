using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;
using SmartEye.Models;

namespace SmartEye.Auth
{
    public class TokenService : ITokenService
    {
        private TimeSpan ExpiryDuration = new(0, 30, 0);
        public string BuildToken(string key, string issuer, string audience, UserModel user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Sub, Guid.NewGuid().ToString())
             };
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new JwtSecurityToken(
            issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.Add(ExpiryDuration),
                notBefore: DateTime.UtcNow,
                signingCredentials: credentials
            );            
            
            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}
