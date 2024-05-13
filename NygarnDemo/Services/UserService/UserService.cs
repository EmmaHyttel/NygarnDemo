using Microsoft.Identity.Client;
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
        public List<Models.User> GetUsers()
        {
            return Users;
        }

        public void AddUser(Models.User user)
        {
            Users.Add(user);
        }
        public Models.User GetUserByUserName(string username)
        {
            //return DbService.GetObjectByIdAsync(username).Result;
            return Users.Find(user => user.UserName == username);
        }

        //public async Task AddUserAsync(Models.User user)
        //{
        //    await Users.AddAsync(user);
        //}

        //public void AddUser(Models.User user)
        //{
        //    Users.Add(user);
        //}
    }
}
