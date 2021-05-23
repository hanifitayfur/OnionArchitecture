using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Domain.Configurations
{
    public class UserConfiguration: BaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Employees");
            entityTypeBuilder.HasKey(ci => ci.Id);
            entityTypeBuilder.Property(ci => ci.Id).IsRequired();
            entityTypeBuilder.Property(ci => ci.Name).IsRequired();
            entityTypeBuilder.Property(ci => ci.Surname).IsRequired();
            entityTypeBuilder.Property(ci => ci.MobilePhoneNumber).IsRequired();
            
            base.Configure(entityTypeBuilder);
        }
    }
}