using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageMyGhanta.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        //foreign key
        [Range(1, int.MaxValue, ErrorMessage ="Please Select a Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0")]
        public int Amount { get; set; }
        [Column(TypeName ="nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitlewithIcon
        {
            get
            {
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string? FormatedAmount
        {
            get
            {
                return ((Category == null || Category.Type=="Expense") ? "- " : "+ ") + Amount.ToString("C0");
            }
        }
    }
}
