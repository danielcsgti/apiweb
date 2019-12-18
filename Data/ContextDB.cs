using appWebApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace appWebApi.Data
{
    public class ContextDB : DbContext
    {
        public DbSet<Usuario> Usuairo { get; set; }
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {

        }
    }
}
