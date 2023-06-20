using Caisse1.Models;
using Microsoft.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore.Metadata;

namespace Caisse1.Data
{
    public partial class CaisseContext : DbContext
    {
        
 

        public CaisseContext(DbContextOptions<CaisseContext> options)
            : base(options)
        {
        }
        public  DbSet<Produit> Produits => Set<Produit>();
        public DbSet<Command> Commands => Set<Command>();
        public  DbSet<Bill> Bills => Set<Bill>();


        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source =(localdb)\MSSQLLocalDB;Initial Catalog=Caisse1;Integrated Security=True");
        }
        



        


        }


}
