using System;
using System.Text;

namespace OOPLaba1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // кодировка
            Console.OutputEncoding = Encoding.UTF8;
            double x, y, z, res;

            do
            {
                x = y = z = res = 0;

                // заповнення даних
                InputData(ref x, ref y, ref z);

                // результат формули
                res = Calculate(ref x, ref y, ref z);

                // вивід даних
                WriteRes(ref res, ref x, ref y, ref z);

                if (x < 1)
                {
                    if (x < 10) Console.WriteLine("X < 10");
                    else Console.WriteLine("X < 1");
                }
                else
                {
                    if (x > 10) Console.WriteLine("X > 10");
                    else Console.WriteLine("X > 1");
                }

                if (res >= 0)
                {
                    if (res == 0) Console.WriteLine("Полупозитив - полунегатив");
                    else Console.WriteLine("Позитивне");
                }
                else Console.WriteLine("Негативне");
                

            } while (x != 0);
            Console.WriteLine("X = 0\nПрограмма завершена.");
            Console.ReadLine();
        }

        static void InputData(ref double x, ref double y, ref double z)
        {
            Console.Write("Введіть x = ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Введіть y = ");
            y = double.Parse(Console.ReadLine());

            Console.Write("Введіть z = ");
            z = double.Parse(Console.ReadLine());
        }

        static double Calculate(ref double x, ref double y, ref double z)
        {
            return x * (Math.Atan(z) + Math.Pow(y, 3));
        }

        static void WriteRes(ref double res, ref double x, ref double y, ref double z)
        {
            Console.WriteLine($"X = {x}\t Y = {y}\t Z = {z}\nРезультат = {res}\n");
        }
    }
}
