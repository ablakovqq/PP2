using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); // Инициализируем данные с помощью конструктора: 0
            Student student2 = new Student("Gappar", "18BD02002", 2018); // 3 параметра
            student.access(); // Метод возвращает данные
            student2.access();
        }
    }
}