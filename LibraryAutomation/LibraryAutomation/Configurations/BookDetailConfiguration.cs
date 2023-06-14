using LibraryAutomation.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Configurations
{
    public class BookDetailConfiguration : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.ID);
            builder.Property(bd => bd.Overview).IsRequired();
            builder.Property(bd => bd.PageNumber).IsRequired();


        }
    }
}
