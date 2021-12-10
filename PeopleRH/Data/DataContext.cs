using PeopleRH.Models;
using Microsoft.EntityFrameworkCore;

namespace PeopleRH.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FolhaPagamento> FolhaPagamentos { get; set; }
    }
}