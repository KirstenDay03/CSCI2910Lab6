using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public class BookService : IBookService
    {
        public Dictionary<int, Book> Books { get; set; } = new Dictionary<int, Book>();
    }
}
