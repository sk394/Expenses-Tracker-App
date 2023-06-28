using System.ComponentModel.DataAnnotations;

namespace ManageMyGhanta.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        //foreign key
        public int Amount { get; set; }
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
