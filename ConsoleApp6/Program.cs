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
            List<int> n = new List<int>() { 1, 2, 3, 13};
            List<int> m = new List<int>() { 3, 2, 0};
            List<int> s = new List<int>();
            var counter = 0;
            for (int i = 0; i < n.Count; i++)
            {
                var number = n[i];
                foreach (int j in m)
                {
                    var number2 = j;
                    if (number != number2)
                    {
                        counter++;
                        continue;
                    }
                }
                if (counter == m.Count)
                {
                    s.Add(number);
                    counter = 0;
                }
                else
                {
                    counter = 0;
                    continue;
                }
                    

                
            }
            Console.WriteLine(string.Join(" ", s));
            Console.ReadKey();
        }
    }
    
}
