using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.models
{
    internal class Car
    {
        int _doorsNum;
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
            Console.WriteLine($"");
        }

    }
}
