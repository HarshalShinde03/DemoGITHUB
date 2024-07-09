using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentGithub
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEllo world");
            Console.WriteLine("First Commit");
            Employee e = new Employee(11, "Harshal");
            e.showName();
            e.showId();
            Console.ReadLine();

        }
    }
}
