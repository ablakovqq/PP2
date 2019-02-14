using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1
{
    class Program
    {
        public static bool isPrime(int x) // Метод, который принимает в себя число, которое мы хотим проверить на Простоту
        {
            if (x < 2)
                return false;
            for (int j = 2; j <= Math.Sqrt(x); ++j) // (Алгоритм: Решето Эратосфена) Форик, благодаря которому можем проверить число на Prime
                if (x % j == 0) // Если находится хотя бы один делитель, кроме 1 и самого числа, то число - составное
                    return false;
            return true;
        }
        static void Main(string[] args) 
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine()); // Конвертируем стринг в целые числа, так как если мы считаем что - либо через Console.ReadLine(), оно будет всегда в виде строки(string)
            int[] a = new int[n]; // Создаем массив размером n
            int cnt = 0, x;
            string[] numbers = Console.ReadLine().Split(); // Считываем строку (набор чисел ex: 1 2 3 4 5), разделяем числа по пробелу и добавляем в массив строк numbers 
            for (int i = 0; i < n; ++i)
            {
                x = Convert.ToInt32(numbers[i]);  // Парсим со стринга в инт
                if (isPrime(x) == true) //Проверка икса на простоту 
                    a[cnt++] = x; // Если будет true, то добавляем наше число в массив
            }
            Console.WriteLine(cnt); // Выводим кол-во прайм чисел
            for (int i = 0; i < cnt; ++i)
            {
                Console.Write(a[i] + " "); // Выводим прайм числа
            }
        }
    }
}