using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
    internal class UserSerivices
    {
        public static string FilePathUsers = @"c:\hh\users.json";
        public static UserCollection UserCol;

        public static UserCollection GetAllUsers()
        {
            if (UserCol == null) UserCol = new UserCollection();
            UserCol.Users = new List<User>();
            if(!File.Exists(FilePathUsers))
            {
                //File.Create(FilePathUsers);
                //create default admin user and add to file
                UserCol.Users.Add(CreateDefaultAdmin());
                string json = JsonSerializer.Serialize(UserCol);
                File.WriteAllText(FilePathUsers, json);
            }
            string jsonString = File.ReadAllText(FilePathUsers);
            UserCol = JsonSerializer.Deserialize<UserCollection>(jsonString);
            return UserCol;
        }
        public static User CreateDefaultAdmin()
        {
            User dAdmin = new User();
            //set aAdmin propetry-values
            dAdmin.Name = "Admin";
            dAdmin.Password = "admin";
            dAdmin.Address = "DefaultAddress";
            dAdmin.Email = "admin@gmail.com";
            dAdmin.Contact = "none";
            dAdmin.Role = Role.Admin;
            return dAdmin;
        }
    }
}
