using Book.Domain.Dtos;
using Book.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Infastructure.Service
{
    public class BookService : IBookService
    {
        public BookDto GetBookByISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return null;
            }
            var book = new BookDto
            {
                Author = "J.R.R Tolkien",
                ISBN = isbn,
                PageCount = 1012,
                PublisherName = "Metis Yayınevi",
                Title = "Yüzüklerin Efendisi Tek Cilt Özel Basım"
            };
            return book;
        }
    }
}
