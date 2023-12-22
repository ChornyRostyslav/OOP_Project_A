using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project_A;

namespace OOP_Project_A
{
    public class Driver : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public int Salary { get; set; }

        public Driver(string firstName, string lastName, int age, string nationality, int salary)
        {
            throw new NotImplementedException();
        }
    }
}
