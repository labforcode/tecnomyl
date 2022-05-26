using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteTecnomyl.Cadastros.Dominios.Entidades.Produtos;

namespace TesteTecnomyl.Cadastros.Infra.Dados.Maps.Produtos
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo");

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(120)")
                   .IsRequired();
        }
    }
}
