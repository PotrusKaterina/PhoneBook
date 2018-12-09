using Lab2IN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Controller
{
    interface ISearchController
    {
        IEnumerable<UserModel> GetContacts();
        IEnumerable<UserModel> SearchContacts(string search);
    }
}
