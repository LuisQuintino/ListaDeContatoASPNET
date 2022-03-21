using Microsoft.EntityFrameworkCore;
using ListaDeContatoASPNET.Models;
namespace ListaDeContatoASPNET.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
