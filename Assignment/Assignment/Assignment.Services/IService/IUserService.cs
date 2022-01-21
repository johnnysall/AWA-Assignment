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

namespace NAA.Services.IService
{
    public interface IUserService
    {
        User GetUser(string userId);
        void UpdateUser(UserProfile userProfile, string userId);
        void AddUser(UserProfile userProfile);
    }
}
