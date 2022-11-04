using BookLib.DataAccess;

namespace BookLib.Repository
{
    public class BookRepository : IBookRepository
    {
        public void InsertBook(Book book) => BookManagement.Instance.Add(book);
    }
}
