using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.models
{
    internal class Vehicle
    {
        private string _brand;
        public string Brand
        {
            get 
            { 
                return _brand;
            }
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _brand = value;
                }
                else
                {
                    throw new Exception("uzunluq duz daxil edilmeyib");
                }
            }
        }
        private string _model;
        public string Model
        {
            get 
            {
                return _model;
            }
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _model = value;
                }
                else
                {
                    throw new Exception("uzunluq duz daxil edilmeyib");
                }
            }
        }
        private double _mile;
        public double Mile
        {
            get 
            { 
                return _mile; 
            }
            set
            {
                if (value > 0)
                {
                    _mile = value;
                }
                else
                {
                    throw new Exception("0dan asagi olammaz");
                }
            }
        }
    }
}
