using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Manager
    {
        private string _deptName;

        //Display & Accept Deptname----

        //get --- returning/retrieving 
        //set --- assigning/accepting

        //Feature---smart method ---for accept & for display---validation
        public string DeptName
        {
            get { return _deptName; }
            set {
                if (value.Length >= 1)
                {
                    _deptName = value;
                }
                else
                {
                    Console.WriteLine("DeptName cannot be Blank.");
                }
            }
        }

    }
}
