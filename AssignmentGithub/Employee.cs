using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGithub
{
    public class Employee
    {
        int _empid;
        string _empname;
        public Employee(int empid, string empname)
        {
            _empid = empid;
            _empname = empname;
        }

        public void showName()
        {
            
            Console.WriteLine(_empname);
        }

        public void showId()
        {
            Console.WriteLine(_empid);
        }
    }
}
