namespace Infrastructure.Mappings.Primitives;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PartMapping : BaseMapping<Part>
{
    public override void Configure(EntityTypeBuilder<Part> builder)
    {
        base.Configure(builder);

        builder.ToTable("tb_part");

        builder.Property(s => s.SerialNumber)
            .HasColumnName("serialnumber")
            .HasMaxLength(255);

        builder.Property(s => s.Status)
            .HasColumnName("status")
            .HasConversion<short>();
    }
}