using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structure
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Мои задачи");
            Console.WriteLine("==================================");
            Console.WriteLine("1 -> Задача 1.Функция согласно блок-схеме");
            Console.WriteLine("2 -> Задача 2.Ответ-комментарий в коде");
            Console.WriteLine("3 -> Задача 3.Вычисление числа Фибоначчи с рекурсией");
            Console.WriteLine("0 -> Завершение работы приложения");
            Console.WriteLine("==================================");

            Console.Write("Введите номер задачи:  ");
            int number = int.Parse(Console.ReadLine());
            
            
            switch (number)
            {
                case 0:
                    Console.WriteLine("Завершение работы приложения . . . ");
                    Console.ReadKey();
                    return;


                    case 1:
                        Test1();
                        break;


                    case 2:
                        Test2();
                        break;

                    case 3:
                        Test3();
                        break;


            }

           static void Test2()
            {
                static int StrangeSum(int[] inputArray) //O(N^3)

                {
                    int sum = 0;
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        for (int j = 0; j < inputArray.Length; j++)
                        {
                            for (int k = 0; k < inputArray.Length; k++)
                            {
                                int y = 0;
                                if (j != 0)
                                {
                                    y = k / j;
                                }
                                sum += inputArray[i] + i + k + j + y;
                            }
                        }
                    }
                    return sum;

                }
            }


            static void Test1()
            {
                bool prost = true;
                Console.WriteLine("Введите число\n");
                int n = int.Parse(Console.ReadLine());
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        prost = false;
                        break;
                    }
                }
                if (prost)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }
                Console.ReadKey();
            }



        }

            static void Test3()
            {
                int Fibonachi(int n)
                {
                    if (n == 0 || n == 1) return n;

                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }

                int fib4 = Fibonachi(4);
                int fib5 = Fibonachi(5);
                int fib6 = Fibonachi(6);

                Console.WriteLine($"4 число Фибоначчи = {fib4}");
                Console.WriteLine($"5 число Фибоначчи = {fib5}");
                Console.WriteLine($"6 число Фибоначчи = {fib6}");

            }

        

    }
}

