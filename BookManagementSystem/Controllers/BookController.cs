using BookManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(new List<Book>());
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok(new Book());
        }
    }
}
