﻿using NygarnDemo.Models;

namespace NygarnDemo.Services.User
{
    public interface IUserService
    {
        List<Models.User> GetAllUsers();

        Task AddUser(Models.User user);

        Models.User GetUserByUserName(string str);

    }
}