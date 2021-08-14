using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Models;

namespace Shop.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "gerente", Password = "matheus1998", Role = "manager" });
            users.Add(new User { Id = 2, Username = "funcionario", Password = "matheus1998", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).First();
        }
    }
}
