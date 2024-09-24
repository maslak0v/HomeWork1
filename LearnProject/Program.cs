using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPoject
{
    using System;

    class Program
    {
        static void Main()
        {
            WriteTable(3, "Hello");
        }

        static void WriteTable(int n, string s)
        {
            // Проверка на корректность входных данных
            if (n < 1 || n > 6)
            {
                Console.WriteLine("Введите число от 1 до 6");
                return;
            }

            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Текст не может быть пустым");
                return;
            }

            int width = 20;
            int textPosition = n - 1;
            int textLength = s.Length;

            // Вычисление ширины полосок
            int stripWidth = (width - textLength - 2 * textPosition) / 2;

            // Проверка на допустимую ширину полосок
            if (stripWidth < 1)
            {
                Console.WriteLine("Невозможно создать полоски с заданными параметрами");
                return;
            }

            // Вывод верхнего прямоугольника с надписью "Привет"
            int topRectHeight = 9;
            int i = 0;
            do
            {
                if (i == 0 || i == topRectHeight)
                {
                    Console.WriteLine(new string('+', width));
                }
                else if (i == topRectHeight / 2)
                {
                    int helloPosition = (width - "Привет".Length) - 8;
                    Console.Write("+");
                    Console.Write(new string(' ', helloPosition));
                    Console.Write("Привет");
                    Console.WriteLine(new string(' ', helloPosition) + "+");
                }
                else
                {
                    Console.WriteLine("+" + new string(' ', width - 2) + "+");
                }
                i++;
            } while (i < topRectHeight);

            // Вывод второго прямоугольника с полосками
            int middleRectHeight = 8;
            i = 0;
            while (i < middleRectHeight)
            {
                if (i == 0 || i == middleRectHeight)
                {
                    Console.WriteLine(new string('+', width));
                }
                else
                {
                    Console.Write("+");
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write((j % 2 == 0) ? "+" : " ");
                    }
                    Console.WriteLine("+");
                }
                i++;
            }

            // Вывод третьего прямоугольника с диагональными полосками
            for (i = 0; i < width; i++)
            {
                if (i == 0 || i == width - 1)
                {
                    Console.WriteLine(new string('+', width));
                }
                else
                {
                    Console.Write("+");
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write((i == j + 1 || i + j == width - 3) ? "+" : " ");
                    }
                    Console.WriteLine("+");
                }
            }
        }
    }
}

