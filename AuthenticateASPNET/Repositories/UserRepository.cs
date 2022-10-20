using System.Collections.Generic;
using System.Linq;
using AuthenticateASPNET.Models;


namespace AuthenticateASPNET.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "danger", Password = "danger", Role = "manager" });
            users.Add(new User { Id = 2, Username = "soft", Password = "soft", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}