using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zashtrihovanaia_Chast
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = 0;
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0)
            {
              max = maxim (N);
            }
                    
               else
                {
                    if (i <= (int)(N - 1) / 2)
                    {
                        for (int k = (N - 1) - i; k < N; k++)
                            if (max < int.Parse(str[k])) max = int.Parse(str[k]);
                    }
                    else
                        for (int d = ((int)(N - 1) / 2) + 1; d < N; d++)
                            if (max < int.Parse(str[d])) max = int.Parse(str[d]);
                }
                    
            }
            Console.WriteLine("{0:f4}", max);
        }

        static double maxim (int num)
        {
            double max = 0;
            for (int i = 0; i < num; i++)
           {
             string[] str = Console.ReadLine().Split();
             if (i <= num / 2)
                for (int j = (num - 1) - i; j < num; j++)
                    if (max < int.Parse(str[j])) max = int.Parse(str[j]);
                    else
                        for (int m = num / 2; m < num; m++)
                            if (max < int.Parse(str[m])) max = int.Parse(str[m]);
           }
        return max;
        }
    }
}
