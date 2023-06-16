using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caisse1.Models
{

    
    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; } // Quantité de produit en stock
        //public ICollection<Command> Commande { get; set; } = new List<Command>();
    }
}
