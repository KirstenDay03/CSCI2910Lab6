using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public class BorrowedService : IBorrowedService
    {
        public Dictionary<User, List<Book>> borrowedBooks { get; set; } = new Dictionary<User, List<Book>>();
    }
}
