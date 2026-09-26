using BusTicket.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTicket.DataAccess
{
    public class ApplictionContext : IdentityDbContext
    {
       public ApplictionContext(DbContextOptions<ApplictionContext> options) : 
            base(options)
        {
        }

        public DbSet<Bus> Bus { get; set; }
        public DbSet<SeatDetail> SeatDetail { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
