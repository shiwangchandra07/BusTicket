using Microsoft.EntityFrameworkCore;
using QuizAPP.Models.Entities;


namespace QuizAPP.Data;

    public class ApplicationDbContext : DbContext

    {
    public ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; }

    public DbSet<Option> Options { get; set; }

}

