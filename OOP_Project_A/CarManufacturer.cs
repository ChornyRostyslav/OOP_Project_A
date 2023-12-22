using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project_A;

namespace OOP_Project_A
{
    public class CarManufacturer
    {
        public string Name { get; set; }
        public int Founded { get; set; }
        public List<Car> Cars { get; set; }

        public CarManufacturer(string name, int founded)
        {
            throw new NotImplementedException();
        }
    }
}
