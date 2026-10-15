using EFCore_4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4
{
    public class BlogDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Profile> Profiles => Set<Profile>();
        protected override void OnConfiguring(DbContextOptionsBuilder 
            optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=COMP1M;
            Database=Blog_Code_First;Integrated Security=True;
            TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User -> Profile
            //1 : 1
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);

            //User -> Posts
            //1 : 1
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p =>  p.AuthorId);
        }
    }
}
