using Animal_Crossing_New_Horizon.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Animal_Crossing_New_Horizon.DAL { 
    public class UtilisateurContext : DbContext
    {

        public UtilisateurContext() : base("UtilisateurContext")
        {
        }

        public DbSet<utilisateurs> Utilisateurs { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<villageois> villageois { get; set; }
        public DbSet<meshabitants> meshabitants { get; set; }
        public DbSet<wishlist> wishlists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
