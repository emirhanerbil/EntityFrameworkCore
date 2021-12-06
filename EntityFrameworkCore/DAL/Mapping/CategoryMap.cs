using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.DAL.Mapping
{
    class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(c => c.Description)
                .HasDefaultValue("No info");

            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "sağlık" },
                new Category { CategoryId = 2, CategoryName = "Bilim" },
                new Category { CategoryId = 3, CategoryName = "Roman" }
                );
        }
    }
}

