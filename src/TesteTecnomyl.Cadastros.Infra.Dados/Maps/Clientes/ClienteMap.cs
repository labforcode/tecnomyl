using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Clientes;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Maps.Clientes
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo")
                   .IsRequired();

            builder.Property(c => c.Cpf)
                   .HasColumnName("cpf")
                   .HasColumnType("varchar(11)")
                   .IsRequired();

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(120)")
                   .IsRequired();

            builder.Property(c => c.CodigoMunicipio)
                   .HasColumnName("codigo_municipio")
                   .IsRequired();

            //one to many
            builder.HasOne(c => c.Municipio)
                    .WithMany(c => c.Cliente)
                    .HasForeignKey(c => c.CodigoMunicipio);
        }
    }
}
