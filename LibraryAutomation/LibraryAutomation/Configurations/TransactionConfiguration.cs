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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.ID);
            builder.HasOne(t => t.User).WithMany(u=>u.Transactions).HasForeignKey(u=>u.UserID);
            builder.HasOne(t => t.Book).WithMany(b => b.Transactions).HasForeignKey(t => t.BookID);
        }
    }
}
