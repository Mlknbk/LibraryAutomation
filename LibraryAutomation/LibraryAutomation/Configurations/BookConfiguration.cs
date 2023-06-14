using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAutomation.Models;

namespace LibraryAutomation.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.ID);
            builder.Property(b => b.Name).IsRequired();

            builder.HasOne(b=>b.Author).WithMany(au=>au.Books).HasForeignKey(b=>b.AuthorID);

            builder.HasOne(b=>b.Publisher).WithMany(p=>p.Books).HasForeignKey(b=> b.PublisherID);

            builder.HasOne(b=>b.BookType).WithMany(bt=>bt.Books).HasForeignKey(b=>b.BookTypeID);

            builder.HasOne(b=>b.BookDetail).WithOne(bd=>bd.Book).HasForeignKey<Book>(b=>b.BookDetailID);

        }
    }
}
