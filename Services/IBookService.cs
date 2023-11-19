using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public interface IBookService
    {
        public Dictionary<int, Book> Books { get; set; }
    }
}
