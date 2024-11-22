using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop2.DAL.Models;

namespace WebShop2.DAL.FluentMapping
{
    internal class KategorijaMap : IEntityTypeConfiguration<Kategorija>
    {
        public void Configure(EntityTypeBuilder<Kategorija> entity)
        {
            entity.ToTable("Kategorija");
            entity.Property(e => e.Naziv).HasMaxLength(50);
        }
    }
}
