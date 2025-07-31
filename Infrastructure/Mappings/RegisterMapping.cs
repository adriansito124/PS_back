using Domain.Entities;
using Infrastructure.Mappings.Primitives;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings;

public class RegisterMapping : BaseMapping<Register>
{
    public override void Configure(EntityTypeBuilder<Register> builder)
    {
        base.Configure(builder);

        builder.ToTable("tb_register");

        builder.HasOne(r => r.Station)
            .WithMany(s => s.Registers)
            .HasForeignKey("station_id")
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(r => r.Part)
            .WithMany(p => p.Registers)
            .HasForeignKey("part_id")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(r => r.DateTime)
            .HasColumnName("datetime");
    }
}