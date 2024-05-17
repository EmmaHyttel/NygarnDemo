namespace NygarnDemo.Models
{
    public class WishList
    {
        public string  User { get; set; }

        public List<WishList> wishLists { get; set; }

        public WishList(string user, List<WishList> wishLists)
        {
            User = user;
            wishLists = new List<WishList>();

        }
        public WishList()
        {
        }
    }
}
