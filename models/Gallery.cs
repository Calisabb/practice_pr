using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.models
{
    internal class Gallery
    {
        public List<Car> cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        { 
            cars.Add(car);
        }

        public List<Car> Filter(string brand)
        {
            return cars.FindAll(x => x.Brand==brand);
        }
        public List<Car> Filter(double mile)
        {
            return cars.FindAll(x => x.Mile==mile);
        }

    }
}
