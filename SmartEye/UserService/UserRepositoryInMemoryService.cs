using SmartEye.Models;

namespace SmartEye.User
{
    public class UserRepositoryInMemoryService : IUserRepositoryService
    {
        private List<UserModel> _users => new()
        {
            new("JeyJey", "Binks"),
        };

        public UserModel GetUser(string userName, string passwrod)
        {
            return _users.FirstOrDefault(x => string.Equals(x.UserName, userName, comparisonType: StringComparison.Ordinal) && string.Equals(x.Password, passwrod, StringComparison.Ordinal));
        }


    }
}
