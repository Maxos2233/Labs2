using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>() { 1, 13, 8, 11, -23, -66 };
            List<int> m = new List<int>() { 1, 5, 4, 13, -66, -23 };
            List<int> s = new List<int>();
            for (int i = 0; i < n.Count; i++)
            {
                var number = n[i];
                foreach (int j in m)
                {
                    var number2 = j;
                    if (number == number2)
                    {
                        s.Add(number);
                        continue;
                    }
                    else
                        
                        continue;
                }
            }
            Console.WriteLine(string.Join(" ", s));
            Console.ReadKey();
        }
    }
    
}
