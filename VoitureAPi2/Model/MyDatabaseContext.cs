using Microsoft.EntityFrameworkCore;
using VoitureApi.Model;

namespace VoitureAPi2.Model
{
    public class MyDatabaseContext:DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options):base(options)
        {

        }
        public DbSet<Voiture> voitures { get; set; }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Evenement> evenements { get; set; }

    }
}
