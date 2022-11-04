using BookLib.DataAccess;

namespace BookLib.Repository
{
    public interface IBookRepository
    {
        void InsertBook(Book book);
    }
}
