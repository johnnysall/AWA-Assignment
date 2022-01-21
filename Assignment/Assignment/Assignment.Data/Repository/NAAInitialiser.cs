using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;
using NAA.Data.DAO;
using NAA.Data.IDAO;


namespace NAA.Data.Repository
{
    public class NAAInitialiser :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<NAAContext>
    {
        protected override void Seed(NAAContext context)
        {
            // Create Uni's
            University UniSheffield = new University() { Name = "Sheffield" };
            University UniDerby = new University() { Name = "Derby" };
            context.Universities.Add(UniSheffield);
            context.Universities.Add(UniDerby);

            // Create Users
            User userOwen = new User() { UserId = "john", Name = "John Salloway", Address = "40 Sheffield Road", Phone = "123456789", Email = "John@gmail.com" };
            context.Users.Add(userOwen);

            // Add Everything to DB
            context.SaveChanges();
        }
    }
}
