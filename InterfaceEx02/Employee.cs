using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.InterfaceEx02

{



    class EmployeeComparerName : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee e01 = (Employee)x;
            Employee e02 = (Employee)y;

            if (e01.Name.Length > e02.Name.Length)
                return 1;
            else if (e01.Name.Length < e02.Name.Length)
                return -1;
            return 0;
        }
    }

    class EmployeeComparerSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee e01 = (Employee)x;
            Employee e02 = (Employee)y;

            if (e01.Salary > e02.Salary)
                return 1;
            else if (e01.Salary < e02.Salary)
                return -1;
            return 0;
        }
    }


    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public Employee() { }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Age = employee.Age;
            Salary = employee.Salary;
        }

        public object Clone()
        {
            //return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;

            //if (this.Age > e.Age) 
            //    return 1;
            //else if(this.Age < e.Age)
            //    return -1;
            //return 0;

            return this.Age.CompareTo(e.Age);
        }
    }
}
