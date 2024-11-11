using BookManagement.Services.Interfaces;
using BookManagementDomain.Interfaces;
using BookManagementDomain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Services.Services
{
    public class BookServices : IBookServices
    {
        private readonly IRepository<Book> _bookRepository;
        public BookServices(IRepository<Book> bookRepository)
        {
            _bookRepository=bookRepository; 
        }
        public Task AddBookAsync(Book book)
        {
            return _bookRepository.AddAsync(book);
        }

        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return _bookRepository.GetAllAsync();
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            return _bookRepository.GetByIdAsync(id);
        }

        public Task RemoveBookAsync(Book book)
        {
           return _bookRepository.RemoveByIdAsync(book);
        }
    }
}
