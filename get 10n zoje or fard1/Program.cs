using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_10n_zoje_or_fard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                x = a[i] % 2;
                if (x == 0)
                {
                    Console.WriteLine("zoje ast");
                }
                else 
                {
                    Console.WriteLine("fard ast");
                }
                
            }

        }
    }
}
