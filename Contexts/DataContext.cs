using Microsoft.EntityFrameworkCore;
using ProjetoAula05.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Contexts
{
    /// <summary>
    /// Classe de contexto do EntityFramework
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método implementado para configurar a conexão do banco de dados
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDProjetoAula05_Noite;Integrated Security=True;");
        }

        /// <summary>
        /// Método implementado para adicionar as classes de mapeamento do projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
