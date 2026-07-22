namespace Store_Online.Core.Models
{
    public class LoginSession
    {
        public bool IsLoggedIn { get; set; }

        public string AccessToken { get; set; } = string.Empty;

        public DateTime LoginTime { get; set; }

        public DateTime ExpireTime { get; set; }

        public UserSession User { get; set; } = new();
    }

    public class UserSession
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}
