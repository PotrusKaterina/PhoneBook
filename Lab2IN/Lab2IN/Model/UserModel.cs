using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2IN.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}",
                Name, Surname, Number, Address);
        }
    }

}
