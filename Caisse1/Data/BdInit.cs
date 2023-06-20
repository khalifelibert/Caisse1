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

            if (context.Produits.Any()
                && context.Commands.Any()
                && context.Bills.Any())

            {
                return;
            }

                

            var produits = new Produit[]
            {
            new Produit{Name="Pizza",Price=5, Quantity =100},
            new Produit{Name="Mac",Price=1200, Quantity =50},
            new Produit{Name="Télé samsung cuvée",Price=800, Quantity =100},
            new Produit{Name="Radio",Price=7, Quantity =50},
            };



            var c1 = new Command { ProduitId = 2, Quantity = 3 };
             var c2 = new Command { ProduitId = 3, Quantity = 1 };
            var c3 = new Command { ProduitId = 2, Quantity = 2 };
            var c0 = new Command { ProduitId = 2, Quantity = 5 };
            var c4 = new Command { ProduitId = 6, Quantity = 1 };
            var c5 = new Command { ProduitId = 3, Quantity = 2 };
            var c6 = new Command { ProduitId = 1, Quantity = 3 };
            var c7 = new Command { ProduitId = 3, Quantity = 6 };


            var bills = new Bill[]
            {
                new Bill
                {
                    DeliveredAT = DateTime.Parse("2023-05-01 10:30"),
                    Commande = new List<Command>{
                        c0,
                        c1, c2
                    }
                },

                new Bill
                {
                    DeliveredAT = DateTime.Parse("2023-05-01 12:11"),
                    Commande = new List<Command>{
                        c0,
                        c7, c4
                    }
                },

                new Bill
                {
                    DeliveredAT = DateTime.Parse("2023-05-01 12:38"),
                    Commande = new List<Command>{
                        c3,
                        c5, c6, c5
                    }
                },
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



            foreach (Bill e in bills)
            {
                context.Bills.Add(e);
            }
            context.Bills.AddRange(bills);
            context.SaveChanges();
        }
    }
}



