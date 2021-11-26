using SmartEye.Models;

namespace SmartEye.User
{
    public interface IUserRepositoryService
    {
        UserModel GetUser(string userName, string passwrod);
    }
}
