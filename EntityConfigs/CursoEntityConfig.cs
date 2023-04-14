using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AplicativoWeb.EntityConfigs;

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {

        builder.ToTable("Curso");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.TituloMarketing)
               .HasColumnType("nvarchar(80)")
               .IsRequired();

        builder.Property(c => c.TituloInterno)
               .HasColumnType("nvarchar(80)")
               .IsRequired();


        builder.Property(c => c.Descricao)
              .HasColumnType("text")
              .IsRequired();
    }
}