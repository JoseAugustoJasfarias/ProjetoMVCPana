using Microsoft.EntityFrameworkCore;
using Pana.Models;

namespace Pana.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<ONG> ONGs { get; set; }
        public DbSet<Login> Logins { get; set; }
    }

}
