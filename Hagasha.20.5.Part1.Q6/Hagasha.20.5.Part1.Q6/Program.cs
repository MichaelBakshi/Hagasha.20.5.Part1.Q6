using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagasha._20._5.Part1.Q6
{
    class Program
    {
        
        static void Main (string[] args)
        {
            
            int[] a ;
            InitializeArrays(out a);
            PrintArray(ref a);
        }
        private static void PrintArray(ref int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        private static void InitializeArrays(out int[] a)
        {
            Random r = new Random();
            a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
            }
        }
    }
}
