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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(ad => ad.ID);
            builder.HasOne(ad => ad.Account).WithOne(a => a.Admin).HasForeignKey<Admin>(ad => ad.AccountID);
        }
    }
}
