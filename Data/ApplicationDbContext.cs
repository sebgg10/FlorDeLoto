using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FlorDeLoto.Models;
using Microsoft.EntityFrameworkCore;

namespace FlorDeLoto.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Platillo> Platillos { get; set; }
}
