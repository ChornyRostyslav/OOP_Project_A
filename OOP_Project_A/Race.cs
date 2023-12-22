using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project_A;

namespace OOP_Project_A
{
    public class Race : IPrintable
    {
        public Car Car1 { get; set; }
        public Car Car2 { get; set; }

        public Race(Car car1, Car car2)
        {
            throw new NotImplementedException();
        }

        public void PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
