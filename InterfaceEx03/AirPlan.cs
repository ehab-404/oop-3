using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx03
{
    internal class AirPlan : IMovable, IFlyable
    {
        int IMovable.speed { get; set; }
        int IFlyable.speed { get; set; }

        void IMovable.Forward()
        {
            Console.WriteLine("Car IMovable ForWard ");
        }
        void IMovable.Backward()
        {
            Console.WriteLine("Car IMovable BackWard ");

        }
        void IMovable.Left()
        {
            Console.WriteLine("Car IMovable Left ");

        }
        void IMovable.Right()
        {
            Console.WriteLine("Car IMovable Right ");

        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Car IFlyable BackWard ");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Car IFlyable ForWard ");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Car IFlyable Left ");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Car IFlyable Right ");
        }
    }
}
