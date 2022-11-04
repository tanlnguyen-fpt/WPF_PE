namespace BookLib.DataAccess
{
    internal class BookManagement
    {
        private static BookManagement instance = null;
        private static readonly object instanceLock = new();
        private BookManagement() { }
        public static BookManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new BookManagement();
                    return instance;
                }
            }
        }

        public void Add(Book book)
        {
            try
            {
                var db = new BookManagementSystemContextContext();
                db.Books.Add(book);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
