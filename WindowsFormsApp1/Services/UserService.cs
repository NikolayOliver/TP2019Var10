using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{
    public class UserService : IServiceContract<UserModel>
    {
        string writePath = @"E:\5 сем\TP\TP2019Var10\WindowsFormsApp1\Users.json";
        string name;
        UsersRepository UsersRepository => JsonSerializer.Deserialize<UsersRepository>(File.ReadAllText(writePath));

        public UserService(string name)
        {
            this.name = name;
        }

        public void AddElement()
        {
            if (!IsNewUser(name))
            {
                var id = CreateUserId();
                var user = new UserModel { Name = name, Id = id };
                SetUsersJson(user);
            }
        }

        public UserModel FindElementById(string id)
        {
            UserModel userModel = null;
            foreach (var useMod in UsersRepository.UsersList)
            {
                if (useMod.Id == id)
                    userModel = useMod;
            }
            return userModel;
        }

        public List<UserModel> GetData()
        {
            return UsersRepository.UsersList;
        }

        private void SetUsersJson(UserModel user)
        {
            var userRepository = UsersRepository;
            userRepository.UsersList.Add(user);
            File.WriteAllText(writePath,JsonSerializer.Serialize<UsersRepository>(userRepository));   
        }

        private string CreateUserId()
        {
            return "User " + (GetData().Count + 1);    
        }

        private bool IsNewUser(string name)
        {

            foreach(var useMod in UsersRepository.UsersList)
            {
                if (useMod.Name == name)
                    return true;
            }
            return false;
        }

        public UserModel GetCurrentUser()
        {
            foreach (var useMod in UsersRepository.UsersList)
            {
                if (useMod.Name == name)
                    return useMod;
            }
            return null;
        }
    }
}
