using Lab2IN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Services.Repository.Users
{
    public interface IUsersRepository
    {
        IEnumerable<UserModel> FetchUsers();
        void AddUser(UserModel user);
        IEnumerable<UserModel> SearchUsers(string search);
    }
}
