using BookManagement.Services.Interfaces;
using BookManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BookController(IBookServices bookServices) 
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var book = await _bookServices.GetAllBooksAsync();
            return Ok(book);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookServices.GetBookByIdAsync(id);
            return Ok(book);
        }
    }
}
