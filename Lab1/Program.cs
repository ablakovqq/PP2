using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1
{
    class Program
    {
        public static bool isPrime(int x)
        {
            if (x < 2)
                return false;
            for (int j = 2; j <= Math.Sqrt(x); ++j) 
                if (x % j == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n]; 
            int cnt = 0, x;
            string[] numbers = Console.ReadLine().Split(); 
            for (int i = 0; i < n; ++i) 
            {
                x = Convert.ToInt32(numbers[i]);
                if (isPrime(x)) 
                    a[cnt++] = x;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; ++i)
            {
                Console.Write(a[i].ToString() + " "); 
            }
        }
    }
}