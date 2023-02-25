namespace Registration.Models
{
    public static class UserCheck
    {
        public static string UserExists(RegistrationContext ctx, string users)
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
}