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
            _users.Add(new UserInfo() { Name = "Ali", Email = "ali@gmail.com", Phone = "87879676", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "ali@gmail.com", Phone = "87879676", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Mehmet", Email = "ali@gmail.com", Phone = "87879676", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Aliş", Email = "ali@gmail.com", Phone = "87879676", WillAttend = true });
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
            _users.Add(user);
        }

    }
}