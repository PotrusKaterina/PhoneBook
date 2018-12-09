using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2IN.Model;
using Lab2IN.Services.DBConnection;
using Lab2IN.Services.Repository.Users;

namespace Lab2IN.Controller
{
    class SearchController : ISearchController
    {
        
        private IUsersRepository usersRepository;

        public SearchController(IConnectionFactory connectionFactory)
        {
            usersRepository = new UsersRepository(connectionFactory);
        }

        public void AddToTable(UserModel value)
        {
            usersRepository.AddUser(value);
        }

        public IEnumerable<UserModel> GetContacts()
        {
            return usersRepository.FetchUsers();
        }

        public IEnumerable<UserModel> SearchContacts(string search)
        {
            return usersRepository.SearchUsers(search);
        }
    }
}
