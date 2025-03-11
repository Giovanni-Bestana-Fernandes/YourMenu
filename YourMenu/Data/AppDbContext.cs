using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoniaStore.Models;
using YourMenu.Models;

namespace YourMenu.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Alergenico> Alergenico { get; set; }
    public DbSet<AreaAcesso> AreaAcesso { get; set; }
    public DbSet<Cardapio> Cardapio { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<ColaboradorHistorico> ColaboradorHistorico { get; set; }
    public DbSet<Comanda> Comanda { get; set; }
    public DbSet<CoresCardapio> CoresCardapio { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<Estabelecimento> Estabelecimento { get; set; }
    public DbSet<EstabelecimentoColaborador> EstabelecimentoColaborador { get; set; }
    public DbSet<EstabelecimentoDefinicao> EstabelecimentoDefinicao { get; set; }
    public DbSet<FormaEntrega> FormaEntrega { get; set; }
    public DbSet<FormaPagamento> FormaPagamento { get; set; }
    public DbSet<Ingrediente> Ingrediente { get; set; }
    public DbSet<Mesa> Mesa { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<PedidoItem> PedidoItem { get; set; }
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Sacola> Sacola { get; set; }
    public DbSet<SacolaItem> SacolaItem { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        AppDbSeed seed = new(builder);
        
        #region Renomear Tabelas do Identity
        builder.Entity<IdentityUser>().ToTable("usuario");
        builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfil");
        builder.Entity<IdentityUserLogin<string>>().ToTable("usuario_login");
        builder.Entity<IdentityUserToken<string>>().ToTable("usuario_token");
        builder.Entity<IdentityRole>().ToTable("perfil");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");
        #endregion
    }
}