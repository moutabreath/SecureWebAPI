namespace SmartEye.Models
{
    public class UserModel
    {
        public UserModel(string userName, string password)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            Password = password;
        }

        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
