using Lab2IN.Model;
using Lab2IN.Services.DBConnection;
using Lab2IN.Services.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Controller
{
    class AddController : IAddController
    {
        private IUsersRepository usersRepository;

        public AddController(IConnectionFactory connectionFactory)
        {
            usersRepository =new UsersRepository(connectionFactory);
        }

        public void AddToData(UserModel value)
        {
            usersRepository.AddUser(value);
        }

    }
}
