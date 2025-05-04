using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Console_Lesson_01
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            int age = 34;
            double height = 1.7;
            //Здесь используется интерполяция строк
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м");
            //В этом случае {0}, {1}, {2} являются плейсхолдерами
            Console.WriteLine("Имя: {0} Возраст: {1} Рост: {2}м", name, age, height);

            Console.ReadKey();
        }
    }
}
