using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Municipios;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Maps.Municipios
{
    public class MunicipioMap : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("municipios");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo")
                   .IsRequired();

            builder.Property(c => c.Uf)
                   .HasColumnName("uf")
                   .HasColumnType("varchar(2)")
                   .IsRequired();

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(250)")
                   .IsRequired();
        }
    }
}
