using Microsoft.EntityFrameworkCore;

namespace ProjetoAgendamento.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Servico> Servicios { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
