using Caisse1.Models;
using System;
using System.Linq;

using System.Diagnostics;

namespace Caisse1.Data
{
    public class BdInit
    {
        public static void Initialize(CaisseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Produits.Any())
            {
                return;   // DB has been seeded
            }

            var produits = new Produit[]
            {
            new Produit{Name="Pizza",Price=5, Quantity =100},
            new Produit{Name="Mac",Price=1200, Quantity =50},
            new Produit{Name="Télé samsung cuvée",Price=800, Quantity =100},
            new Produit{Name="Radio",Price=7, Quantity =50},
            };

            foreach (Produit s in produits)
            {
                context.Produits.Add(s);
            }
            context.SaveChanges();

            var commands = new Command[]
            {
            new Command{ProduitId=10,Quantity=3},
            new Command{ProduitId=5,Quantity=2},
            new Command{ProduitId=1,Quantity=2},

           
            };
            foreach (Command c in commands)
            {
                context.Commands.Add(c);
            }
            context.SaveChanges();

            var bills = new Bill[]
            {
            new Bill{DeliveredAT =DateTime.Parse("2023-05-01")},
            new Bill{DeliveredAT =DateTime.Parse("2023-05-02")},
            new Bill{DeliveredAT =DateTime.Parse("2023-05-03")},

            };
            foreach (Bill e in bills)
            {
                context.Bills.Add(e);
            }
            context.SaveChanges();
        }
    }
}



