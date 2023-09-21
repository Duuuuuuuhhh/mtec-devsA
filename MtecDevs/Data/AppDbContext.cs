using Microsoft.AspNetCore.Identiny.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;

namespace MtecDevs.Data;


public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions opcoes) : base(opcoes)
    {       
    }

    public DbSet<Usuario> Usuarios { get; set; }
     public DbSet<TipoDev> TipoDevs { get; set; }

     protected override void onModelCreating(ModelBuilder builder)
    {
        base.onModelCreating(builder);
    }

}