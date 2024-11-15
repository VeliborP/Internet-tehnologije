using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
        modelBuilder.Entity<Kategorija>(entity =>
        {
            entity.ToTable("Kategorija");

            entity.Property(e => e.Naziv).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
