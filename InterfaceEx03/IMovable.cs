using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx03
{

    internal interface IMovable
    {
        int speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }
}
