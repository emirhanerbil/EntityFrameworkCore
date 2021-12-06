using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entities
{
    class Book
    {
        
        public int BookId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
    }
}
