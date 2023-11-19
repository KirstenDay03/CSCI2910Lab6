using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public class UserService : IUserService
    {
        public Dictionary<int, User> Users { get; set; } = new Dictionary<int, User>();
    }
}
