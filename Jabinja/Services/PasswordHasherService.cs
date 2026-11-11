using Jabinja.Entity;
using Microsoft.AspNetCore.Identity;

namespace Jabinja.Services;

public class PasswordHasherService : IPasswordHasherService
{
    private readonly PasswordHasher<User> _passwordHasher = new();

    public string Hash(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password cannot be empty.");

        return _passwordHasher.HashPassword(null!, password);
    }

    public bool VerifyPassword(string passwordHash, string password)
    {
        if (string.IsNullOrWhiteSpace(passwordHash) ||
            string.IsNullOrWhiteSpace(password))
            return false;

        var result = _passwordHasher.VerifyHashedPassword(
            null!,
            passwordHash,
            password
        );

        return result != PasswordVerificationResult.Failed;
    }
}