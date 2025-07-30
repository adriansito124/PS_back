namespace Infrastructure.Mappings.Primitives;

using Domain.Entities.Primitives;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BaseMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id)
               .HasName($"PK_{typeof(T).Name}");

        builder.Property(e => e.Id)
               .HasColumnName("id")
               .ValueGeneratedOnAdd();
    }
}