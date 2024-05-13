using NygarnDemo.Models;

namespace NygarnDemo.Services.User
{
    public interface IUserService
    {
        List<Models.User> GetUsers();

        Task AddUserAsync(Models.User user);

        Models.User GetUserByUserName(string str);

    }
}