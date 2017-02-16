using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime my_age =Convert.ToDateTime(Console.ReadLine());
            int year =Convert.ToInt32( DateTime.Now.Subtract(my_age).TotalDays) / 360;
            Console.WriteLine("your age is "+year + "year");
            Console.ReadKey();
        }
    }
}





