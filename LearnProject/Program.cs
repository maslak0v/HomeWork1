using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject
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

            // Проверка на допустимую длину строки
            if (textLength > width - 2 * textPosition - 2)
            {
                Console.WriteLine("Строка слишком длинная для заданной позиции");
                return;
            }

            // Вычисление ширины полосок
            int stripWidth = (width - textLength - 2 * textPosition) / 2;

            // Проверка на допустимую ширину полосок
            if (stripWidth < 1)
            {
                Console.WriteLine("Невозможно создать полоски с заданными параметрами");
                return;
            }

            // Отрисовка трех таблиц
            DrawTopTable(width);
            DrawMiddleTable(width);
            DrawBottomTable(width);
        }

        static void DrawTopTable(int width)
        {
            int height = 9;
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height)
                {
                    Console.WriteLine(new string('+', width));
                }
                else if (i == height / 2)
                {
                    int helloPosition = (width - "Привет".Length - 2) / 2;
                    Console.Write("+");
                    Console.Write(new string(' ', helloPosition));
                    Console.Write("Привет");
                    Console.WriteLine(new string(' ', helloPosition) + "+");
                }
                else
                {
                    Console.WriteLine("+" + new string(' ', width - 2) + "+");
                }
            }
        }

        static void DrawMiddleTable(int width)
        {
            int height = 8;
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height)
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
            }
        }

        static void DrawBottomTable(int width)
        {
            for (int i = 0; i < width; i++)
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
                        Console.Write((i == j + 1 || i + j == width - 2) ? "+" : " ");
                    }
                    Console.WriteLine("+");
                }
            }
        }
    }
}
