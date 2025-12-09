using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
    }
}
