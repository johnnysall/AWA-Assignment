using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;

namespace NAA.Data.DAO
{
    public class UserDAO : IUserDAO
    {
        public User GetUser(string userId, NAAContext context)
        {
            User user = context.Users.Find(userId);
            return user;
        }

        public void UpdateUser(User user, NAAContext context)
        {
            User userToUpdate = GetUser(user.UserId, context);
            context.Entry(userToUpdate).CurrentValues.SetValues(user);
            context.SaveChanges();
        }

        public void AddUser(User user, NAAContext context)
        {
            context.Users.Add(user);
        }
    }
}
