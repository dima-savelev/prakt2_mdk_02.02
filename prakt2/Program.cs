using System;
using System.Text;

namespace prakt2
{
    public class Program
    {
        private const string _str = "abcdefghiklmnopqrstvxyzABCDEFGHIKLMNOPQRSTVXYZ";
        static void Main(string[] args)
        {
            Console.Write("Введите размер массивов: ");

            int.TryParse(Console.ReadLine(), out int number);
            if (number < 2 || number > 100)
            {
                Console.WriteLine("Размер массива должен быть больше одного и не больше ста");
                return;
            }

            StringBuilder builder = new();
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"массив {i}: ");
                var mas = FillMas(number);
                if (Calculation(mas)) builder.Append(i + " ");
            }

            if (builder.Length == 0)
            {
                Console.Write("Таких массивов нет");
                return;
            }
            Console.WriteLine(builder);
            Console.ReadLine();

        }
        private static string[] FillMas(int number)
        {
            string[] mas = new string[number];
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                mas[i] = Convert.ToString(_str[rnd.Next(_str.Length)]);
                Console.Write(mas[i]);
            }
            Console.WriteLine();
            return mas;
        }

        private static bool Calculation(string[] mas)
        {
            bool first = mas[0] == mas[0].ToLower();
            for (int i = 1; i < mas.Length; i++)
            {
                bool actual = mas[i] == mas[i].ToLower();
                if (actual == first) return false;
                first = actual;
            }
            return true;
        }

    }
}
