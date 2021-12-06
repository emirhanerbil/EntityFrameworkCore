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
                new Book { BookId = 1, Title = "Devlet",CategoryId = 3 },
                new Book { BookId = 2, Title = "Yol", CategoryId =3  }
                );
            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

