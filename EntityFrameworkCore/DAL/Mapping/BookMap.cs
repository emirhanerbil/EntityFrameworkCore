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
                .HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Book { BookId = 1, Title = "Devlet" },
                new Book { BookId = 2, Title = "Yol" }
                );
        }
    }
}
