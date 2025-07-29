using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx03
{

    internal class Cars : IMovable
    {
        public int speed { get; set; }
        public void Forward()
        {
            Console.WriteLine("Car IMovable ForWard ");
        }
        public void Backward()
        {
            Console.WriteLine("Car IMovable BackWard ");

        }
        public void Left()
        {
            Console.WriteLine("Car IMovable Left ");

        }
        public void Right()
        {
            Console.WriteLine("Car IMovable Right ");

        }
    }
}
