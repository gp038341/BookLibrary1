using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Application.Interfaces;
using BookLibrary.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;
        public BookRepository(IDbContextFactory<ApplicationDbContext> factory)
        {
            context = factory.CreateDbContext();    
        }
        public async Task AddAsync(Book book)
        {
            context.Books.Add(book);
            await context.SaveChangesAsync();
        }

        public Task<List<Book>> GetAllAsync()
        {
            var books = context.Books.ToListAsync();
            return books;
        }
        public async Task<Book?> GetByIdAsync(int id)
        {
            var book = await context.Books.FirstOrDefaultAsync(e=> e.Id == id);
            return book;
        }
        public async Task UpdateAsync(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
        public async Task DeleteByIdAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if (book != null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> SearchByNameAsync(string name)
        {
            var books = await context.Books
                .Where(b => b.Title.Contains(name))
                .ToListAsync();
            return books;
         
        }
    }
}
