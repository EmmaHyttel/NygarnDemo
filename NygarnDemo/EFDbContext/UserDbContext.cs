﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext;

public class UserDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Data Source=mssql17.unoeuro.com;
							Initial Catalog=nygarndemo_dk_db_projekt;
							User ID=nygarndemo_dk;
							Password=drHmxBw4p6nkFcha2Abt;
							Connect Timeout=30;Encrypt=True;
							Trust Server Certificate=True;
							Application Intent=ReadWrite;
							Multi Subnet Failover=False;
							Connect Timeout=30; 
							Encrypt=False"
        );
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users")
            .HasData(
             ReturnUserWithHashedPassword(
                new User()
                {
                    Id = 1,
                    UserName = "admin",
                    Name = "NEM",
                    LastName = "HARD",
                    Password = "secretzz",
                    Address = "En sej gade",
                    Phone = "69696969",
                    Email = "nem_hard@garn.dk"
                }),
            ReturnUserWithHashedPassword(
                new User()
                {
                 Id = 2,
                 UserName = "EmmaStrikker123",
                 Name = "Emma",
                 LastName = "Hyttel",
                 Password = "maiv",
                 Address = "Vejgade 1",
                 Phone = "12345678",
                 Email = "emmastrikker@garn.dk"
                }),
                ReturnUserWithHashedPassword(
              new User()
              {
                  Id = 3,
                  UserName = "MaiStrikker123",
                  Name = "Mai",
                  LastName = "Dinh",
                  Password = "maiv",
                  Address = "Vejgade 2",
                  Phone = "23456789",
                  Email = "maistrikker@garn.dk"
              }),
                ReturnUserWithHashedPassword(
              new User()
              {
                  Id = 4,
                  UserName = "NannaHækler123",
                  Name = "Nanna",
                  LastName = "Rister",
                  Password = "maiv",
                  Address = "Vejgade 3",
                  Phone = "34567891",
                  Email = "nannahækler@garn.dk"
              })
                );
    }


    public DbSet<User> UserTable { get; set; }

    private User ReturnUserWithHashedPassword(User user)
    {
        var passwordHasher = new PasswordHasher<string>();

        user.Password = passwordHasher.HashPassword(user.UserName, user.Password);

        return user;
    }
}


