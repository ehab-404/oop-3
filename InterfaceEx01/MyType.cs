using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx01
{
    internal class MyType : IMyType//, ICloneable, IComparable //Interface ==> Implementation
    {//u can dow multipule implementation and also add inheretence
        #region V01

        //as automatic Properity
        public double Salary { get; set; }
        //public double Salary
        //{
        //    get { throw new NotImplementedException(); }
        //    set { throw new NotImplementedException(); }


        //}

        public void MyFun()
        {

            Console.WriteLine("Hello World");


            #endregion
            
        }
    }
}
