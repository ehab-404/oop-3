using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx02
{
    internal class SeriesBy2 : Iseries
    {
        #region V02
        public int Current { get; set; }

       public void Next()
        {
            Current += 2;
        }

        void Iseries.Next()
        {
            Next();
        }

        void Reset()
        {
            Current = 0;
        }

        void Iseries.Reset()
        {
            Reset();
        }

        #endregion
    }
}
