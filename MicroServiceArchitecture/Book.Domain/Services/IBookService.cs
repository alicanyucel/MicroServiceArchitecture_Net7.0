using Book.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Domain.Services
{
    public interface IBookService
    {
        BookDto GetBookByISBN(string isbn);
    }
}
