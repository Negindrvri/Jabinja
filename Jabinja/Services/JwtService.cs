using Jabinja.Entity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jabinja.Services;

public class JwtService(IConfiguration configuration) : IJwtService
{
    public string GetJwtToken(User user)
    {
        var jwtSecret = configuration["Settings:JwtSecret"]!;
        var issuer = configuration["Settings:Issuer"]!;
        var audience = configuration["Settings:Audience"]!;

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwtSecret));

        var credentials = new SigningCredentials(
            key, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.MobilePhone, user.PhoneNumber)
        };


        if (user is JobSeeker)
        {
            claims.Add(new Claim(ClaimTypes.Role, "JobSeeker"));
        }
        else if (user is Employer)
        {
            claims.Add(new Claim(ClaimTypes.Role, "Employer"));
        }

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddHours(4),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}