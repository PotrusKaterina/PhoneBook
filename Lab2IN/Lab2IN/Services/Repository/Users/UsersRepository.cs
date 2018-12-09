using Dapper;
using Lab2IN.Model;
using Lab2IN.Services.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Services.Repository.Users
{
    class UsersRepository: IUsersRepository
    {
        private IConnectionFactory factory;

        public UsersRepository(IConnectionFactory connection)
        {
            factory = connection;
        }

        public IEnumerable<UserModel> FetchUsers()
        {
            using (var sqlConnection = factory.CreateConnection)
            {
                var users = sqlConnection.Query<UserModel>("SELECT * from UsersTable").ToList();
                return users;
            }
        }

        public void AddUser(UserModel user)
        {
            using (var sqlConnection = factory.CreateConnection)
            {
                sqlConnection.Execute(@"insert into UsersTable(Name, Surname, Number, Address)
                values (@Name, @Surname, @Number, @Address);",
                new { Name = user.Name, Surname = user.Surname, Number = user.Number, Address = user.Address});
            }
        }

        public IEnumerable<UserModel> SearchUsers(string search)
        {
            using (var sqlConnection = factory.CreateConnection)
            {
                IEnumerable<UserModel> users = sqlConnection.Query<UserModel>(@"SELECT * from UsersTable
                                                                                WHERE Name LIKE @search
                                                                                OR Surname LIKE @search
                                                                                OR Number LIKE @search", new { search = "%"+search+"%" }).ToList();
                return users;
            }
        }
    }
}
