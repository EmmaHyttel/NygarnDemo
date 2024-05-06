using NygarnDemo.MockData;
using NygarnDemo.Models;

namespace NygarnDemo.Services.User
{
    public class UserService : IUserService
    {
        public List<Models.User> Users { get; set; }


        public UserService()
        {
            Users = MockUser.GetAllUsers();

        }
        public List<Models.User> GetAllUsers()
        {
            return Users;
        }

        public async Task AddUser(Models.User user)
        {
            Users = MockUser.GetAllUsers();
        }
        public Models.User GetUserByUserName(string username)
        {
            //return DbService.GetObjectByIdAsync(username).Result;
            return Users.Find(user => user.UserName == username);
        }

    }
}
