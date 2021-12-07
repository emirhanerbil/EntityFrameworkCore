using EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.DAL
{
    class BookDal
    {
        public void AddBook()
        {
            var context = new DBContext();

            var book = new Book()
            {
                BookId = 1,
                CreatedDate = DateTime.Now,
                Title = "Beyaz Diş"
            };
            context.Add(book);
            context.SaveChanges();

        }
    }
}
