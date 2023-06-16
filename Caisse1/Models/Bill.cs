using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caisse1.Models
{
    //[Table("Bills")]
    public class Bill
    {
        public int Id { get; set; }
        //public int ProduitId { get; set; }
        public DateTime DeliveredAT { get; set; }

       // public Produit Produit { get; set; } = null!;
        public ICollection<Command> Commande { get; set; } = null!;
    }
}