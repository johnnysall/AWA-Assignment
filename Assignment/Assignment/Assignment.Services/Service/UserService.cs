using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.DAO;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;
using NAA.Services.IService;
using NAA.Services.Models;

namespace NAA.Services.Service
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;
        public UserService()
        {
            userDAO = new UserDAO();
        }

        public User GetUser(string userId)
        {
            using (var context = new NAAContext())
            {
                User user = userDAO.GetUser(userId, context);
                return user;
            }
        }

        public void UpdateUser(UserProfile userProfile, string userId)
        {
            using (var context = new NAAContext())
            {
                User _user = userDAO.GetUser(userId, context);

                _user.Name = userProfile.Name;
                _user.Address = userProfile.Address;
                _user.Phone = userProfile.Phone;
                _user.Email = userProfile.Email;

                userDAO.UpdateUser(_user, context);
            }
        }

        public void AddUser(UserProfile userProfile)
        {
            User newUser = new User()
            {
                UserId = userProfile.UserId,
                Name = userProfile.Name,
                Address = userProfile.Address,
                Phone = userProfile.Phone,
                Email = userProfile.Email,
            };

            using(var context = new NAAContext())
            {
                userDAO.AddUser(newUser, context);
                context.SaveChanges();
            }
        }
    }
}
