



using System.Text;
using oop_3.InterfaceEx01;
using oop_3.InterfaceEx02;
using oop_3.InterfaceEx03;

namespace oop_3
{


    //dataTypes that could create in name space
    //1.Class
    //2.Struct
    //Enum
    //Interface : Reference Type


    internal class Program
    {

        static void Print10Number(SeriesBy2 series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        static void Print10Number(SeriesByThree series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        static void Print10Number(SeriesByFour series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        // u can do ine function
        static void print10number(Iseries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        static void Main(string[] args)    
        {





            #region v02 Interface
            // Interface : One of the dataTypes that could create in name space
            //Code Contract between the developer who write and the developer who use


            //Note : u can't Create Object from Interface

            //Mytype mytype = new Mytype();
            //mytype.Salary = 12000;
            //Console.WriteLine(mytype.Salary);
            //mytype.MyFun();


            //Note U can create any ref throw interface

            IMyType myType;
            //Ref --> Can refer to Object From any Class which implement the interface"IMytype"
            MyType mytype = new MyType();
            mytype.Salary = 12000;
            Console.WriteLine(mytype.Salary);
            mytype.MyFun();


            #endregion

            #region V03

           SeriesBy2 seriesBy2 = new SeriesBy2();
            Print10Number(seriesBy2);

            SeriesByThree seriesByThree = new SeriesByThree();

            Print10Number(seriesByThree);

            SeriesByFour seriresByFour = new SeriesByFour();
            Print10Number(seriresByFour);


            //int[] numbers = { 7, 5, 3, 4, 6, 7, 8, 9, 14, };
            //Array.Sort(numbers); //Sortng By Asce
            //foreach (int item in numbers) 
            //{
            //    Console.WriteLine(item);
            //}

            Employee[] employees = new Employee[3]
            {
                new Employee() {Id =1, Name="Ahmed" , Age=30,Salary=12000 },
                new Employee() {Id =2, Name="Omar" , Age=27,Salary=13000 },
                new Employee() {Id =3, Name="Amr" , Age=28,Salary=11000 },
            };

            Array.Sort(employees);
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Vo4
            Cars car = new Cars();
            car.speed = 120;
            car.Forward();

            AirPlan airPlan = new AirPlan();

            //Create ref to call the function
            IMovable movable=new Cars();
            movable.Forward();

            IFlyable flyable = airPlan;
            flyable.Forward();





            #endregion









            #region V05

            // Shallow Copy Vs Deep Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Ziad", "Adel", "Amr" };

            StringBuilder[] Arr01 = new StringBuilder[]
            {
                new StringBuilder("Ahmed"),
                new StringBuilder("Ali"),
                new StringBuilder("Omar")
            };

            StringBuilder[] Arr02 = new StringBuilder[]
            {
                new StringBuilder("Amr"),
                new StringBuilder("Adel"),
                new StringBuilder("Ziad")
            };


            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Shallow Copy

            Arr02 = (StringBuilder[])Arr01.Clone(); // 
            // Copy Identity
            // { 1, 2, 3 } ---> Has Two References Arr01, Arr02
            // { 4, 5, 6 } ---> UnReachable Object

            Console.WriteLine();
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State [Data]

            Arr02[0].Append(" Ahmed Amin");
            Console.WriteLine(Arr01[0]);


            //// Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Arr02 = (int[])Arr01.Clone();    // Deep Copy
            //// Clone Method will copy the object State of the caller
            //// Assign The New Object To Arr02, Will  Generate new Identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State [Data]

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);


            #endregion







        }
    }
}
