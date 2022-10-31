using marcondes.Model;
using Microsoft.EntityFrameworkCore;

namespace marcondes.DataBase
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext>
        options) : base(options){

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            var cliente = modelBuilder.Entity<Cliente>();
            cliente.ToTable("cliente");
            cliente.HasKey(x => x.Id);
            cliente.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            cliente.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            cliente.Property(x => x.NomeSocial).HasColumnName("nome_social");
            cliente.Property(x => x.DataNascimento).HasColumnName("data_nascimento");
            cliente.Property(x => x.Identidade).HasColumnName("identidade");
            cliente.Property(x => x.Cpf).HasColumnName("cpf");
            cliente.Property(x => x.Celular).HasColumnName("celular");
            cliente.Property(x => x.Endereco).HasColumnName("endereco");
            cliente.Property(x => x.Estado).HasColumnName("estado");
            cliente.Property(x => x.Cidade).HasColumnName("cidade");
            cliente.Property(x => x.Cep).HasColumnName("cep");
            cliente.Property(x => x.Email).HasColumnName("email");
        }
    }
}