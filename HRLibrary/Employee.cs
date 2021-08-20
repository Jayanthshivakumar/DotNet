using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {

        static int empid;
        string _ename, _city;
        int _projectCode, empno;

        public static void addEmp()
        {
            empid += 1;
            Console.WriteLine("Your Emp ID = "+empid);
        }

        public void AcceptDetails()
        {
            addEmp();//static method  can be called in non static method
            empno = empid;//assign static variable to a non-static variable
       
            Console.WriteLine("Enter the ename: ");
            _ename = Console.ReadLine();
            Console.WriteLine("Enter the City: ");
            _city = Console.ReadLine();
            Console.WriteLine("Enter the Project Code: ");
            _projectCode = Convert.ToInt32(Console.ReadLine());

        }

        public void ShowDetails()
        {
            Console.WriteLine("Displaying the Details: ");
            Console.WriteLine("Empnp is : "+empno);
            Console.WriteLine("Employee Name: "+ _ename);
            Console.WriteLine("City: "+_city);
            Console.WriteLine("Project Code: "+_projectCode);
        }
    }
}
