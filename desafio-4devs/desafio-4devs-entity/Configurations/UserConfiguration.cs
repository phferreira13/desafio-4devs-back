using desafio_4devs_domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace desafio_4devs_entity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(u => u.UpdatedAt);
            builder.HasKey(u => u.Id);
            builder.HasMany(u => u.Reviews).WithOne(r => r.User).HasForeignKey(r => r.UserId);
        }
    }
}
