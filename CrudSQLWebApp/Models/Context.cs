using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CrudSQLWebApp.Models
{
    public class Context : DbContext //Conexão co banco de Dados
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

    }
}
