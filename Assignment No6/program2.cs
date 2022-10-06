using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No6
{
    public class program2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Calculate();
            Console.WriteLine(s1.GetValues());

            Student s2 = new Student(12, "Roshani", 70, 80, 85);
            s2.Calculate();
            Console.WriteLine(s2.GetValues());
        }
    }
}
