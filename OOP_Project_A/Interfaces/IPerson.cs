using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project_A;

namespace OOP_Project_A
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Nationality { get; set; }
    }
}
