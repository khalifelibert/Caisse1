

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caisse1.Models
{

   // [Table("Commands")]
    public class Command
    {
        public int Id { get; set; }
        public int ProduitId { get; set; }
        public int Quantity { get; set; } // Quantité de produit demandé dans la commande


       // public ICollection<Produit> Produits { get; set; } = new List<Produit>();
        public Produit Produit { get; set; } = null!;
    }
}

// 