/*namespace Assignment_1.Models
{
    public static class UserCheck
    {
        public static string UserExists(ApplicationContext ctx, string users)
        {
            string msg = string.Empty;
            if (!string.IsNullOrEmpty(users)) {
                var UserE = ctx.User.FirstOrDefault(
                    u => u.Username.ToLower() == users;
                )
                if (UserE != null) 
                    msg = $"Username {users} already in use.";
            }
            return msg;
        }
    }
}*/