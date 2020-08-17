using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wrapper
    {
        public LoginUser LoginUser { get; set; }
        public List<User> AllUsers { get; set; }
        public User User { get; set; }
        public List<Wedding> AllWeddings { get; set; }
        public Wedding Wedding { get; set; }
        public List<GuestList> AllGuestLists { get; set; }
        public GuestList GuestList { get; set; }
        public int CurrentUser { get; set; }
    }
}