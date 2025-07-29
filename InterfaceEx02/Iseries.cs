using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx02
{
    //how to do interface doing this  for numbers
    // 0 2 4 6 8 10
    internal interface Iseries
    {
        int Current { get; set; }        //1.Signature of property in interface

        void Next();
        void Reset();


    }
}
