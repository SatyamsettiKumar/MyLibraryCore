﻿using MyLibraryCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryCore.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);

        void CreateBook(Book book);
        void UpdateBook(int? id,  Book book);
        void DeleteBook(int? id);
    }
}
