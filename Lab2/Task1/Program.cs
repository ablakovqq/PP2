using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"/Users/Gappar/Desktop/Lab2/Task1/input.txt"); // Указываем путь к файлу для того чтобы прочитать его текст
            char[] txet = text.ToCharArray();
            Array.Reverse(txet);
            string s = new string(txet);
            if (s == text)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}