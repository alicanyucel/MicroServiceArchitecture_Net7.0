using Book.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService BookService;
        public BookController(IBookService bookService)
        {
            BookService = bookService;
        }
        [HttpGet]
        [Route("getall")]
        public ActionResult Get(string isbn)
        {
            var book = BookService.GetBookByISBN(isbn);
            return Ok(book);
        }
    }
}