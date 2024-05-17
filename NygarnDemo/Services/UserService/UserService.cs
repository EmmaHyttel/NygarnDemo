using Microsoft.Identity.Client;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;

namespace NygarnDemo.Services.User
{
    public class UserService : IUserService
    {
        private UserDbService _userDbService;
        public List<Models.User> Users { get; set; }


        public UserService(UserDbService dbService)
        {
            //Users = MockUser.GetAllUsers();
            _userDbService = dbService;
            Users = _userDbService.GetUsers().Result.ToList();
            _userDbService.SaveUsers(Users);
        }
        public List<Models.User> GetUsers()
        {
            return Users;
        }

        public Models.User GetUserByUserName(string username)
        {
            //return DbService.GetObjectByIdAsync(username).Result;
            return Users.Find(user => user.UserName == username);
        }

        public List<Models.User> GetAllUsers()
        {
            return Users;
        }


        public async Task AddUserAsync(Models.User user)
        {
            await _userDbService.AddUser(user);
        }
    }
}
