using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public interface IBorrowedService
    {
        public Dictionary<User, List<Book>> borrowedBooks { get; set; }
    }
}