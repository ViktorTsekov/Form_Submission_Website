using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WP.Models;

namespace WP.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Form> Forms { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Forms)
                .WithOne(x => x.User);

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}

