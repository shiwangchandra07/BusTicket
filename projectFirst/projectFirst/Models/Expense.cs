

using System.ComponentModel.DataAnnotations;

namespace projectFirst.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue , ErrorMessage ="Am,ount need to be greater than 0 .")]

        public double Amount { get; set; }
        [Required]

        public string Category { get; set; } = null!;

        public DateTime Date { get; set; } = DateTime.Now;

    }
}
