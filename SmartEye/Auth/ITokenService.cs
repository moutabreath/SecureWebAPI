using SmartEye.Models;

namespace SmartEye.Auth
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, string audience, UserModel user);
    }
}
