
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PostgreSqlDemo.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]

        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author {  get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal price {  get; set; }

        [Required(ErrorMessage = "Quantity is required")]

        public int quantity {  get; set; }


    }
}
