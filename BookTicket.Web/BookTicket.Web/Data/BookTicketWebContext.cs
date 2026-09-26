using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class BookTicketWebContext(DbContextOptions<BookTicketWebContext> options) : IdentityDbContext<BookTicket.Web.Data.ApplicationUser>(options)
{
}
