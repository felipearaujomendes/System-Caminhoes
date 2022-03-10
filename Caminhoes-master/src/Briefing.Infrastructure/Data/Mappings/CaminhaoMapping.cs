using caminhoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace caminhoes.Infrastructure.Data.Mappings
{
    public class CaminhaoMapping: IEntityTypeConfiguration<Caminhao>
    {
        public void Configure(EntityTypeBuilder<Caminhao> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Modelo).HasColumnType("Varchar(100)").IsRequired();

            builder.ToTable("Pergunta");
        }
    }
}
