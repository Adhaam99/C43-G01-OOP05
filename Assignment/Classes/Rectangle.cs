using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    class Rectangle : IRectangle
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle area is {Area}");
        }
    }
}
