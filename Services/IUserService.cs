using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public interface IUserService
    {
        public Dictionary<int, User> Users { get; set; }
    }
}
