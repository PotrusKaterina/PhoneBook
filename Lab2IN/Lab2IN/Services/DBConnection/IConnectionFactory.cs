using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Services.DBConnection
{
    interface IConnectionFactory
    {
        SqlConnection CreateConnection { get; }
    }
}
