using Caisse1.Models;
using Microsoft.EntityFrameworkCore;


using Microsoft.EntityFrameworkCore.Metadata;

namespace Caisse1.Data
{
    public partial class CaisseContext : DbContext
    {
        
        public CaisseContext()
        {
        }


        public CaisseContext(DbContextOptions<CaisseContext> options)
            : base(options)
        {
        }
        public  DbSet<Produit> Produits { get; set; }
        public DbSet<Command> Commands { get; set; } = null!;
        public  DbSet<Bill> Bills { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source =(localdb)\MSSQLLocalDB;Initial Catalog=Caisse1;Integrated Security=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>();
            modelBuilder.Entity<Bill>();
            modelBuilder.Entity<Produit>();
            

        }



        }


}
