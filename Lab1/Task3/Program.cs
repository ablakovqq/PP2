using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static void dublicate(string[] s, int n) // Дубликация с двумя параметрами 
        {
            string[] ss = new string[n * 2];
            for (int i = 0, j = 0; i < n; ++i)
            {
                ss[j++] = s[i]; // Дублируем
                ss[j++] = s[i];
            }
            for (int i = 0; i < 2 * n; ++i)
                Console.Write(ss[i] + " ");
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Конвертируем первую строку в целые числа 
            string[] reading = Console.ReadLine().Split(); // Конвертируем вторую строку массива путем разделение
            dublicate(reading, n); // Дублируем каждый элемент
        }
    }
}