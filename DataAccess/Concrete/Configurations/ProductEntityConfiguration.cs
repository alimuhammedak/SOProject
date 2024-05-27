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
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.ColorID);
            builder.Property(x => x.Size);
            builder.Property(x => x.CreatedUserId);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.LastUpdatedUserId);
            builder.Property(x => x.LastUpdatedDate);
            builder.Property(x => x.Status);
            builder.Property(x => x.isDeleted);

            builder.HasOne(x => x.Color)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.ColorID);

            builder.HasMany(x => x.WarehouseProductMappings)
                   .WithOne(x => x.Product)
                   .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.Orders)
                   .WithOne(x => x.Product)
                   .HasForeignKey(x => x.ProductId);
        }
    }

}
