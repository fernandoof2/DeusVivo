using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DeusVivo.Domain.Services
{
    public class ServiceToken : IServiceToken
    {
        public string GenerateToken(UsuarioEO usuario, string secret) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Id", usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Login),
                    new Claim(ClaimTypes.Role, usuario.Login)
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    algorithm:SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
