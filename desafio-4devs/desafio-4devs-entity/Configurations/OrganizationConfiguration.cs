using desafio_4devs_domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_4devs_entity.Configurations
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.ContactName).IsRequired();
            builder.Property(o => o.CreatedAt).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(o => o.UpdatedAt);
        }
    }
}
