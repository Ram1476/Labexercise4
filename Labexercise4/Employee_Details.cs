using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labexercise4
{
    internal class Employee_details
    {
        public int empId;
        public string EmpName;
        public int Age;
        public string EmpDOB;
        public int Basichra;

        public void emp_details() 
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"\nEmp_ID: {empId}\n\nEmp_Name: {EmpName}\n\n" +
                $"Emp_Age: {Age}\n\nEmp_DOB: {EmpDOB}\n\nEmp_Basic_HRA: {Basichra}");
            Console.WriteLine("---------------------------------------");
        } 
    }
}
