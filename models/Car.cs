using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.models
{
    internal class Car : Vehicle
    {
        int _doorsNum;

        public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
        {
            DoorsNum = doorsNum;
        }

        public int DoorsNum 
        {
            get
            { 
                return _doorsNum;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    _doorsNum = value;
                }
                else
                {
                    throw new Exception();
                }
            
            }
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, WheelsNum: {DoorsNum}");
        }

    }
}
