using Microsoft.EntityFrameworkCore;
using Migrante.App.Dominio;

namespace Migrente.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<PersonaMigrante> Migrantes {get;set;}


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = FullWorkDB");
                
            }
        }

    }
}