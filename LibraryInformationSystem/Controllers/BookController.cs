using LibraryInformationSystem.Interfaces;
using LibraryInformationSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryInformationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository )
        {
            this._bookRepository = bookRepository;  
        }
        [HttpGet]
        [ProducesResponseType( 200, Type = typeof(IEnumerable<Book>) )]
        public IActionResult GetBooks()
        {
            var books = _bookRepository.GetBooks();
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(books);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Book))]
        public IActionResult GetBook(int id)
        {
            var book = _bookRepository.GetBook(id);
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }
            return Ok(book);    
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        public IActionResult GetBookByCategory(int categoryId)
        {
            var books = _bookRepository.GetBookByCategory(categoryId);
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(books);

        }
        
    
    }
}
