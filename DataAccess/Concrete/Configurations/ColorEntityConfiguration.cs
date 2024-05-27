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
    public class ColorEntityConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.CreatedUserId);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.LastUpdatedUserId);
            builder.Property(x => x.LastUpdatedDate);
            builder.Property(x => x.Status);
            builder.Property(x => x.isDeleted);

            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Color)
                   .HasForeignKey(x => x.ColorID);
        }
    }

}
