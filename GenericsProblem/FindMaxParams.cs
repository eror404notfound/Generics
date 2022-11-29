using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class FindMaxParams
    {
        public static void MaxValue(params int[] values)
        {
            Array.Sort(values);
            Console.WriteLine("Maximum Value : " + values[values.Length - 1]);
        }
    }
}
