using Microsoft.EntityFrameworkCore;
using WebShop2.DAL.FluentMapping;

namespace WebShop2.DAL.Models;

public partial class WebShop2Context : DbContext
{
    public WebShop2Context()
    {
    }

    public WebShop2Context(DbContextOptions<WebShop2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategorija> Kategorijas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new KategorijaMap());
    }
}
