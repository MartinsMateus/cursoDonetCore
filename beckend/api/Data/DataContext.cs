using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base (opt){ }

        public DbSet<Evento> Eventos {get; set;}        
    }
}