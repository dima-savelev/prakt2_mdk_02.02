using System;

namespace prakt2
{
    class Program
    {
        private static string _str = "abcdefghiklmnopqrstvxyzABCDEFGHIKLMNOPQRSTVXYZ";
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите размер массивов");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 1 && number <= 100)
                {
                    Console.Write("Первый массив: ");
                    FillMas(number, out string[] mas1);
                    Console.Write("Второй массив: ");
                    FillMas(number, out string[] mas2);
                    Console.Write("Третий массив: ");
                    FillMas(number, out string[] mas3);
                    Console.Write("Четвертый массив: ");
                    FillMas(number, out string[] mas4);
                    Console.Write("Пятый массив: ");
                    FillMas(number, out string[] mas5);
                    Console.WriteLine("Массивы с чередующимися строчными и прописными буквами:");
                    Calculation(mas1, out bool result1);
                    if (result1)
                    {
                        Console.Write("1 ");
                    }
                    Calculation(mas2, out bool result2);
                    if (result2)
                    {
                        Console.Write("2 ");
                    }
                    Calculation(mas3, out bool result3);
                    if (result3)
                    {
                        Console.Write("3 ");
                    }
                    Calculation(mas4, out bool result4);
                    if (result4)
                    {
                        Console.Write("4 ");
                    }
                    Calculation(mas5, out bool result5);
                    if (result5)
                    {
                        Console.Write("5");
                    }
                    if (result1 == false && result2 == false && result3 == false && result4 == false && result5 == false)
                    {
                        Console.Write("Таких массивов нет");
                    }
                }
                else
                {
                    Console.WriteLine("Размер массива должен быть больше одного и не больше ста");
                }
            }
            catch
            {
                Console.WriteLine("Размер введен неверно");
            }
            Console.ReadLine();

        }
        private static void FillMas(int number, out string[] mas)
        {
            mas = new string[number];
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                mas[i] = Convert.ToString(_str[rnd.Next(46)]);
                Console.Write(mas[i]);
            }
            Console.WriteLine();
        }
        private static void Calculation(string[] mas, out bool result)
        {
            bool lower;
            result = true;
            if (mas[0] == mas[0].ToLower())
            {
                lower = true;
            }
            else lower = false;
            for (int i = 1; i < mas.Length; i++)
            {
                if (lower == true)
                {
                    if (mas[i] == mas[i].ToUpper())
                    {
                        lower = false;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    if (mas[i] == mas[i].ToLower())
                    {
                        lower = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
        }
    }
}
