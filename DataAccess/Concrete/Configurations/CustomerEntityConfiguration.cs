using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(100);
            builder.Property(x => x.LastName).HasMaxLength(100);
            builder.Property(x => x.CustomerCode).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.MobilePhone).HasMaxLength(30);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.CreatedUserId);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.LastUpdatedUserId);
            builder.Property(x => x.LastUpdatedDate);
            builder.Property(x => x.Status);
            builder.Property(x => x.isDeleted);

            builder.HasMany(x => x.Orders)
                   .WithOne(x => x.Customer)
                   .HasForeignKey(x => x.CustomerId);
        }
    }

}
