using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx02
{
    internal class SeriesByThree : Iseries
    {
        public int Current { get; set; }


        public void Next()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
