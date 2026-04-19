using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.models
{
    internal class Bcycle : Vehicle
    {
        private int _wheelsNum;

        public Bcycle(string brand, string model, double mile, int wheelsNum) : base(brand, model, mile)
        {
            WheelsNum = wheelsNum;
        }

        public int WheelsNum 
        {
            get
            { 
                return _wheelsNum;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    _wheelsNum = value;
                }
                else
                {
                    throw new Exception();
                }
            
            }
        }
         public void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Mile: {Mile}, WheelsNum: {WheelsNum}");
        }

    }
}
