using FinanceApp.Models;
using Microsoft.EntityframeworkCore;

namespace projectFirst.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options): base(options) { }





        DbSet<Expense> Expenses { get; set; } 
    }
}
