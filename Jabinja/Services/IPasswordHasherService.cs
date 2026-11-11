namespace Jabinja.Services;

public interface IPasswordHasherService
{
    string Hash(string password);
    bool VerifyPassword(string passwordHash,string password);
}
