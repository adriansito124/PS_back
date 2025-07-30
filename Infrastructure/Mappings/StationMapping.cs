namespace Infrastructure.Mappings.Primitives;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StationMapping : BaseMapping<Station>
{
    public override void Configure(EntityTypeBuilder<Station> builder)
    {
        base.Configure(builder);

        builder.ToTable("tb_station");

        builder.Property(s => s.Name)
            .HasColumnName("name")
            .HasMaxLength(255);

        builder.Property(s => s.Index)
            .HasColumnName("index");
    }
}