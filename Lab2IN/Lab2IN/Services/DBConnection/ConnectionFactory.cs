using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Services.DBConnection
{
    class ConnectionFactory: IConnectionFactory
    {
        public SqlConnection CreateConnection
        {
            get
            {
                var domain = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                var path = domain + "\\Data\\PhoneBook.mdf";
                return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename="+ path +"; Integrated Security = True; ");
            }
        }
    }
}
