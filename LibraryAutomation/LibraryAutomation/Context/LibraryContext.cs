using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryAutomation.Models;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using LibraryAutomation.Configurations;

namespace LibraryAutomation.Context
{
    public class LibraryContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new BookTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BookDetailConfiguration());


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=LibraryAutomation;uid=sa;pwd=123;TrustServerCertificate=true;");

        }
    }
    
}
