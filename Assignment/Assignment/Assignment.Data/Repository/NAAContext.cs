using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NAA.Data.Models.Domain;
using NAA.Data.DAO;
using NAA.Data.IDAO;

namespace NAA.Data.Repository
{
    public class NAAContext : DbContext
    {
        public NAAContext() : base("NAAContext")
        {
            Database.SetInitializer<NAAContext>(new NAAInitialiser());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
