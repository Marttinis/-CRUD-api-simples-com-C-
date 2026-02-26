using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Models;

namespace ProjetoAPI.Data
{
    public class ProjetoAPIContext : DbContext
    {
        public ProjetoAPIContext (DbContextOptions<ProjetoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoAPI.Models.Usuario> Usuario { get; set; } = default!;
    }
}
