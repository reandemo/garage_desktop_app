namespace Store_Online.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string BranchName { get; set; } = "";
        public string ProfileName { get; set; } = "";
        public string Status { get; set; } = "";
    }

    public class CreateUserRequest
    {
        public string Username { get; set; } = "";

        public string Password { get; set; } = "";

        public int BranchId { get; set; }

        public int ProfileId { get; set; }
    }
    public class ProfileModel
    {
        public int Id { get; set; }

        public string ProfileName { get; set; } = string.Empty;
    }

    public class BranchModel
    {
        public int Id { get; set; }

        public string BranchName { get; set; }=string.Empty;
    }
}
