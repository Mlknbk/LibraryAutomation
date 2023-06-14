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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.ID);
            builder.Property(u=>u.FirstName).IsRequired();
            builder.Property(u=>u.LastName).IsRequired();
            builder.Property(u=>u.BirthDate).IsRequired();

            builder.HasOne(u=>u.Account).WithOne(a=>a.User).HasForeignKey<User>(u=>u.AccountID);
        }
    }
}
