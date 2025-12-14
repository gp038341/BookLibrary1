using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Enums;

namespace BookLibrary.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task UpdateAsync(Book book);
        Task DeleteByIdAsync(int id);

        Task <List<Book>> SearchByNameAsync(string name);

        Task<List<Book>> SearchByGenreAsync(Genre genre);
    }
}
