using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1,Name = "Ali", Email = "ali@gmail.com", Phone = "87879676", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2,Name = "Ahmet", Email = "ali@gmail.com", Phone = "87879676", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3,Name = "Mehmet", Email = "ali@gmail.com", Phone = "87879676", WillAttend = false });
            _users.Add(new UserInfo() { Id = 4,Name = "Aliş", Email = "ali@gmail.com", Phone = "87879676", WillAttend = true });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }


        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}