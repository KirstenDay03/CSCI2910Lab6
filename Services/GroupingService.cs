using CSCI2910Lab6.Data;

namespace CSCI2910Lab6.Services
{
    public class GroupingService : IGroupingService
    {
        public List<BookGroup> BookGroups { get; set; } = new List<BookGroup>();
    }
}
