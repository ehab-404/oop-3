using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class Circle : ICircle
    {
        public double Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("circle  shape ");
        }
    }
}
