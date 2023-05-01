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
            List<int> n = new List<int>() { 2, 1, -3, 5};
            List<int> m = new List<int>() { -1, -6, 2, 5};
            List<int> s = new List<int>();
            List<int> l = new List<int>();
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

            counter = 0;
            if (n.Count >= m.Count)
            {
                for (int i = 0; i < n.Count; i++)
                {
                    var number = n[i];
                    var itog = 0;
                    if (counter < m.Count)
                    {
                        for (int j  = 0; j < m.Count;)
                        {
                            var number2 = 0;
                            j = counter;
                            number2 = m[j];
                            itog = number - number2;
                            l.Add(itog);
                            break;
                        }
                    }

                    else
                    {
                        l.Add(number);
                    }
                    counter++;
                }
                
            }
            else
            {
                for (int i = 0; i < m.Count; i++)
                {
                    var number2 = m[i];
                    var itog = 0;
                    if (counter < n.Count)
                    {
                        for (int j = 0; j < n.Count;)
                        {
                            var number = 0;
                            j = counter;
                            number = n[j];
                            itog = number - number2;
                            l.Add(itog);
                            break;
                        }
                    }

                    else
                    {
                        l.Add(number2);
                    }
                    counter++;
                }
            }
            

            Console.WriteLine(string.Join(" ", s));
            Console.WriteLine(string.Join(' ', l));
            Console.ReadKey();
        }
    }
    
}
