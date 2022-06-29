using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    {
        static void Game()
        {
            string maket_1 = "___________";
            string maket_2 = "|1|2|3|4|5|";
            char[,] lake = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    lake[i, j] = 's';
            }
            Cannon cannon = new Cannon(lake);

            char Cannon_C = ' ';
            int column = 0;
            bool program = true;

            Console.WriteLine("\t|ГРА З РИБКАМИ|");
            Console.WriteLine("\nНажимайте '↓' - щоб втягнути рибку у пушку\nНажимайте '↑' - щоб зкормити рибку iншiй");
            Console.WriteLine("\nНажимайте '←' - щоб перемiститись влiво\nНажимайте '→' - щоб перемiститись вправо");
            while (program)
            {
                Console.WriteLine("\n" + maket_1);
                Console.WriteLine(maket_2);
                cannon.Print(column, Cannon_C);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Cannon_C = cannon.Pull(Cannon_C, column);
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Cannon_C = cannon.Push(Cannon_C, column);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (column != lake.GetLength(0) - 1)
                        column++;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (column != 0)
                        column--;
                }
            }
        }
        static void Main(string[] args)
        {
            Game();
            Console.ReadKey();
        }
    }
}
