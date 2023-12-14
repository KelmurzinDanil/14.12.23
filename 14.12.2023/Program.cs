using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;  // Подключаем рефлексию

namespace _14._12._2023
{
    internal class Program
    {
        public static void OutputOfNumbers() // Вывод чисел от 1 до 10
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(300);
                Console.Write($"{i} ") ;
            }
        }
        public static int CalculatingTheFactorial(int k) // Вычисление факториала
        {
            if (k < 0)
            {
                Console.WriteLine("Факториал отрицательного числа не высчитывается");
            }
            if (k == 1 || k == 0)
            {
                return 1;
            }

            return k * CalculatingTheFactorial(k - 1);
        }
        public static async Task<int> AsyncCalculatingTheFactorial(int k) // Вычисление факториала асинхронно
        {   
            await Task.Delay(8000); // Задержка асинхронного метода
            return await Task.Run(() => CalculatingTheFactorial(k));
        }
        public static double CalculatingSquare(int number)
        {
            return number * number;
        }
         async static Task Main(string[] args)
        {
            Console.WriteLine("Упр. 1");
            Thread thread1 = new Thread(new ThreadStart(OutputOfNumbers));
            Thread thread2 = new Thread(new ThreadStart(OutputOfNumbers));
            Thread thread3 = new Thread(new ThreadStart(OutputOfNumbers));
            thread1.Start();
            thread2.Start();
            thread3.Start();

            try
            {
                Thread.Sleep(3500);
                Console.WriteLine("\nУпр. 2");
                Console.WriteLine("Введите целое число: ");
                int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Квадрат: " + CalculatingSquare(n));
                Console.WriteLine("Ждем 8 секунд");
                Console.WriteLine("Факториал: " + await AsyncCalculatingTheFactorial(n));
            }
            catch 
            {
                Console.WriteLine("Вы ввели что-то не то");
            }
            Console.WriteLine("Упр. 3");
            Type typeRef1 = typeof(Ref1);
            foreach(MemberInfo memberInfo in typeRef1.GetMethods())
            {
                Console.WriteLine($"{memberInfo.Name}");
            }

            Console.ReadKey();
        }
    }
}
