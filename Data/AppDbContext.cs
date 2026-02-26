using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Models;

namespace ProjetoAPI.Data
{
    public class AppDbContext : DbContext
    {
        //Construtor do Banco de dados
        //ele detem a configurações do Banco de dados
        public AppDbContext(DbContextOptions options) : base(options) { }

        //schema
        //Nesta se ler, estou criando um banco chamado Cadastro e dentro dele vai
        //ser criado uma tabela chamada Usuario
        public DbSet<Usuario> Cadastro { get; set; }
       
    }
}
