using BookManagementDomain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Services.Interfaces
{
    public interface IBookServices
    {
        Task AddBookAsync(Book book);
        Task RemoveBookAsync(Book book);

        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
    }
}
