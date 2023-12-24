using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_HomeWork_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                /*
                
                double num1, num2;
                int act;

                try
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите арифметическое действие: \n1 - сложение \n2 - вычитание \n3 - умножение \n4 - деление");

                act = int.Parse(Console.ReadLine());

                if (act == 1)
                {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                }
                else if (act == 2)
                {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                }
                else if (act == 3)
                {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                }
                else if (act == 4)
                {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Ошибка: было введено некоректное число или действие");
                }

                Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                Console.ReadLine();

                */

                double num1, num2;
                int act;

                try
                {
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    num2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите арифметическое действие: \n1 - сложение \n2 - вычитание \n3 - умножение \n4 - деление");

                act = int.Parse(Console.ReadLine());

                switch (act)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Ошибка: было введено некоректное действие");
                        break;
                }

                Console.WriteLine("Нажмите Enter чтобы очистить консоль");
                Console.ReadLine();
            }
        }
    }
}
