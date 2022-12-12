using Microsoft.EntityFrameworkCore;

namespace EstagioCrud.Models
{
    // classe para conexao com banco 
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

    }
}
