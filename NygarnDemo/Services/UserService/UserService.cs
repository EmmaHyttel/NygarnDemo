using Microsoft.Identity.Client;
using NygarnDemo.MockData;
using NygarnDemo.Models;

namespace NygarnDemo.Services.User
{
    public class UserService : IUserService
    {
        private DbService _dbService;
        public List<Models.User> Users { get; set; }


        public UserService(DbService dbService)
        {
            //Users = MockUser.GetAllUsers();
            _dbService = dbService;
            Users = _dbService.GetUsers().Result.ToList();
            _dbService.SaveUsers(Users);
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
            await _dbService.AddUser(user);
        }
    }
}
