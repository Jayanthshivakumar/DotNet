using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace OOPSDemo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Merging");
            Console.WriteLine("Hello");

            Employee emp = new Employee();//Object Creation
            Employee emp1 = new Employee();//instance or object----heap----default constructor

            Manager mgr = new Manager();

            char ans;
            do
            {
                Console.WriteLine("Press 1.add employee | 2.Accept Details | 3.Show Details");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Employee.addEmp();
                        break;
                    case 2:
                        //emp.AcceptDetails();
                        //emp1.AcceptDetails();
                        Console.WriteLine("Enter Deptname");
                        mgr.DeptName = Console.ReadLine();

                        break;
                    case 3:
                        //emp.ShowDetails();
                        //emp1.ShowDetails();
                        Console.WriteLine("Your deptName is : " + mgr.DeptName);
                      
                        break;
                        //default:
                }

                Console.WriteLine("Do u want to do another operation");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'Y' || ans == 'y');


            //Console.WriteLine("Enter 1st no");
            //int no1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd no");
            //int no2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Entr 1 for  add 2 for sub 3.multiply ");
            //int ch = Convert.ToInt32(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        int answer = MathsLogic.add(no1, no2);
            //        Console.WriteLine(answer);
            //        break;

            //    case 2:
            //        answer = MathsLogic.subtract(no1, no2);
            //        Console.WriteLine(answer);
            //        break;
            //    case 3:
            //        answer = MathsLogic.mulitply(no1, no2);
            //        Console.WriteLine(answer);
            //        break;


            //}



            Console.ReadLine();

        }
    }
}
