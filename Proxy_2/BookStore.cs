using System.Linq;

namespace Proxy_2
{
    public class BookStore : IBook
    {
        PageContext db;

        public BookStore()
        {
            db = new PageContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }
    }
}