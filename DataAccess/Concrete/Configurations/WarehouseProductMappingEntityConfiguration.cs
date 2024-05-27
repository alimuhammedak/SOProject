﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class WarehouseProductMappingEntityConfiguration : IEntityTypeConfiguration<WarehouseProductMapping>
    {
        public void Configure(EntityTypeBuilder<WarehouseProductMapping> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.WarehouseId);
            builder.Property(x => x.Quentity);
            builder.Property(x => x.ReadyForSale);
            builder.Property(x => x.CreatedUserId);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.LastUpdatedUserId);
            builder.Property(x => x.LastUpdatedDate);
            builder.Property(x => x.Status);
            builder.Property(x => x.isDeleted);

            builder.HasOne(x => x.Warehouse)
                   .WithMany(x => x.WarehouseProductMappings)
                   .HasForeignKey(x => x.WarehouseId);

            builder.HasOne(x => x.Product)
                   .WithMany(x => x.WarehouseProductMappings)
                   .HasForeignKey(x => x.ProductId);
        }
    }

}
