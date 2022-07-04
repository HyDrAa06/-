using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Намиране_на_просто_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int br = 0;

            Console.Write("Въведете число: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        br++;
                    }

                }
                if (br == 2)
                {
                    Console.WriteLine(i);
                }
                br = 0;
            }

            Console.ReadLine();

        }
    }
}
