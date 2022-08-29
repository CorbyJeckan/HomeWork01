using System;


namespace Algorithms
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Algorithms";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здравствуйте!\nПожалуйста,введите пункт для выбора домашнего задания.\nДоступные для выбора пункты:\n1 - Напишите на C# функцию согласно блок-схеме.\n2 - Рассчёт сложности функции. \n3 - Реализуйте функцию вычисления числа Фибоначчи.");
            string selectednumber = (Console.ReadLine());
            switch (selectednumber)
            {
                case "1":
                    {
                        Class1.NumberCheck();
                    }
                    break;

                case "2":
                    {
                        Class2.Function();
                    }
                    break;


                case "3":
                    {
                        Fibonachi.Fibonaccirdy(args);
                    }
                    break;
            }
        }
    }

}
