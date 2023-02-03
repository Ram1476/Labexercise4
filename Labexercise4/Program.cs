using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labexercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_details emp1 = new Employee_details(); 
            Console.Write("Enter Emp_ID: ");
            emp1.empId = Convert.ToInt32( Console.ReadLine());
            Console.Write("\nEnter Emp_Name: ");
            emp1.EmpName = Console.ReadLine();
            Console.Write("\nEnter Emp_Age:");
            emp1.Age = Convert.ToInt32( Console.ReadLine());
            Console.Write("\nEnter Emp_DOB: ");
            emp1.EmpDOB =  Console.ReadLine();
            Console.Write("\nEnter Emp_Basic_HRA: ");
            emp1.Basichra = Convert.ToInt32( Console.ReadLine());

            emp1.emp_details();

            Console.ReadLine();
        }
    }
}
