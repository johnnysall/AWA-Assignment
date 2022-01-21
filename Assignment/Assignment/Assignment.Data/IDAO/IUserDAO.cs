using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;
using NAA.Data.Repository;

namespace NAA.Data.IDAO
{
    public interface IUserDAO
    {
        User GetUser(string userId, NAAContext context);
        void UpdateUser(User user, NAAContext context);
        void AddUser(User user, NAAContext context);
    }
}
