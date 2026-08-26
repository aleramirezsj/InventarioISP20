using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Backend.Data
{
    public class InventarioContext: DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
