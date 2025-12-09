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
    }
}
