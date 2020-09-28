using MyLibraryCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryCore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,BookName="GOT",Author="AryaStark",ISBN="2EERT5G",PublishedDate=Convert.ToDateTime("10/10/2013")},
                new Book{Id=2,BookName="SEE",Author="Jason",ISBN="2FGhT5G",PublishedDate=Convert.ToDateTime("11/11/2016")},
                new Book{Id=3,BookName="SEEN",Author="BabaVoss",ISBN="2UTYUI",PublishedDate=Convert.ToDateTime("12/12/2019")},
            };
        }

        public void UpdateBook(int? id, Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
