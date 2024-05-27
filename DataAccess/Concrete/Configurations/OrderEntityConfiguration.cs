using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.Configurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerId);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.Piece);
            builder.Property(x => x.CreatedUserId);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.LastUpdatedUserId);
            builder.Property(x => x.LastUpdatedDate);
            builder.Property(x => x.Status);
            builder.Property(x => x.isDeleted);

            builder.HasOne(x => x.Customer)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.CustomerId);

            builder.HasOne(x => x.Product)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.ProductId);
        }
    }

}
