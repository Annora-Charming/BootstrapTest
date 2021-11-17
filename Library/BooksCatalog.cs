using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BooksCatalog
    {
        private List<Book> _books;

        public BooksCatalog()
        {
            _books = new List<Book>();
        }

        public bool AddBook(Book aBook)
        {
            if (aBook == null) 
            {
                throw new ArgumentNullException(nameof(aBook));
            }

            if (_books.Exists(b => b.InventoryNumber == aBook.InventoryNumber))
            {
                return false;
            }

            _books.Add(aBook);

            return true;
        }

        public IReadOnlyCollection<Book> GetAll()
        {
            return _books.AsReadOnly();
        }
    }
}
