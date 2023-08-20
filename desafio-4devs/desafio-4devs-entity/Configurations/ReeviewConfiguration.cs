using desafio_4devs_domain.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_4devs_entity.Configurations
{
    public class ReeviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasAlternateKey(x => new { x.ReferenceMonth, x.ReferenceYear, x.OrganizationId, x.UserId });
            builder.Property(x => x.ReferenceMonth).IsRequired().HasMaxLength(2);
            builder.Property(x => x.ReferenceYear).IsRequired().HasMaxLength(4);
            builder.Property(x => x.Rating).IsRequired();
            builder.Property(x => x.Comment).IsRequired();
            builder.Property(x => x.OrganizationId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.HasOne(x => x.Organization).WithMany(x => x.Reviews).HasForeignKey(x => x.OrganizationId);
            builder.HasOne(x => x.User).WithMany(x => x.Reviews).HasForeignKey(x => x.UserId);
        }
    }
}
