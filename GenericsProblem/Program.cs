using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Problem : ");
            FindMaximum Number = new FindMaximum();
            FindMaximum.FindMaxValue(20.5f, 10.3f, 11.3f);
            Console.ReadLine();
        }
    }
}
