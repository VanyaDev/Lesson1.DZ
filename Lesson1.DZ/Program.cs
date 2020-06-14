using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson1.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО:");
            string input = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            string inputA = Console.ReadLine();
            float A = float.Parse(inputA.Replace(".", ","));
            Console.WriteLine("Введите рост:");
            string inputB = Console.ReadLine();
            float B = float.Parse(inputB.Replace(".", ","));
            Console.WriteLine("Введите номер телефона:");
            string inputC = Console.ReadLine();
            Console.WriteLine("Введите ваш адрес:");
            string inputF = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ваше ФИО: " + input);
            Console.WriteLine("Ваш возраст: " + inputA);
            Console.WriteLine("Ваш рост: " + inputB);
            Console.WriteLine("Ваш номер телефона: " + inputC);
            Console.WriteLine("Ваш адресс: " + inputF);
        }
    }
}
