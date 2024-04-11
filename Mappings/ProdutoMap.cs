using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Mappings
{
    /// <summary>
    /// Classe de mapeamento ORM para entidade Produto
    /// </summary>
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //nome da tabela
            builder.ToTable("PRODUTO");

            //chave primária
            builder.HasKey(p => p.Id);

            //mapeamento do campo 'Id'
            builder.Property(p => p.Id).HasColumnName("ID");

            //mapeamento do campo 'Nome'
            builder.Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();

            //mapeamento do campo 'Quantidade'
            builder.Property(p => p.Quantidade).HasColumnName("QUANTIDADE").IsRequired();

            //mapeamento do campo 'Preco'
            builder.Property(p => p.Preco).HasColumnName("PRECO").HasColumnType("decimal(10,2)").IsRequired();

            //mapeamento do campo 'Status'
            builder.Property(p => p.Status).HasColumnName("STATUS");

        }
    }
}
