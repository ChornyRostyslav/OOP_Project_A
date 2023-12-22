using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project_A;

namespace OOP_Project_A
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public CarType Type { get; set; }
        public IPerson Owner { get; set; }
        public Car(int id, string model, int year, CarType type)
        {
            throw new NotImplementedException();
        }
    }
}
