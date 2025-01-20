using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Interfaces;

namespace Assignment.Classes
{
    class Circle : ICircle
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle area is {Area}");
        }

    }
}
