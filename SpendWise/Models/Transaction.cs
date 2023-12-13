using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpendWise.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }

        public int Amount { get; set;  }

        public DateTime Date { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
