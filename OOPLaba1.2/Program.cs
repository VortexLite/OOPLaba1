using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLaba1_2
{
    internal class Program
    {
        // константи на вагу
        public const double butter1kg = 1;
        public const double sourCream2kg = 2;
        public const double cream3kg = 3;


        static void Main(string[] args)
        {
            // кодировка
            Console.OutputEncoding = Encoding.UTF8;
            double butter, sourCream, cream, res;
            butter = sourCream = cream = res = 0;

            // обрахунок даних + сумма всього
            Calculation(ref butter, ref sourCream, ref cream, ref res);

            // вивід даних
            Print(ref butter, ref sourCream, ref cream, ref res);
        }

        static void Calculation(ref double butter, ref double sourCream, ref double cream, ref double res)
        {
            butter = butter1kg * 8.50;
            sourCream = sourCream2kg * 2.40;
            cream = cream3kg * 4.10;

            res = butter + sourCream + cream;
        }

        static void Print(ref double butter, ref double sourCream, ref double cream, ref double res)
        {
            Console.WriteLine($"Масло = {butter}\nСметана = {sourCream}\nВершки = {cream}\nЗагальна сумма = {res}");
            Console.ReadLine();
        }
    }
}
