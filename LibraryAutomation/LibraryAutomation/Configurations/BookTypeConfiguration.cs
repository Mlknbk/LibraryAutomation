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
    public class BookTypeConfiguration : IEntityTypeConfiguration<BookType>
    {
        public void Configure(EntityTypeBuilder<BookType> builder)
        {
            builder.HasKey(bt => bt.ID);
            builder.Property(bt => bt.Name).IsRequired();


        }
    }
}
