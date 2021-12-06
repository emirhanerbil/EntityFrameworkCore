using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.DAL.Mapping
{
    class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(b => b.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.HasData(
                new Book { BookId = 1, Title = "Devlet" },
                new Book { BookId = 2, Title = "Yol" }
                );
        }

    }
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

