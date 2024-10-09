using Microsoft.EntityFrameworkCore;
using Tarefas.Models;

namespace Tarefas.Context
{
    public class OrganizadorContext(DbContextOptions<OrganizadorContext> options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}