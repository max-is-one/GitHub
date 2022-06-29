using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            string maket = "|1|2|3|4|5|";
            char[,] lake = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    lake[i,j] = 's';
            }
            Cannon cannon = new Cannon(lake);
          
            
            char Cannon_C = ' ';
            int column = 0;
            bool program = true;
            
            Console.WriteLine("\t|ГРА З РИБКАМИ|");
            Console.WriteLine("\nНажимайте '↓' - щоб втягнути рибку у пушку\nНажимайте '↑' - щоб зкормити рибку iншiй");
            Console.WriteLine("\nНажимайте '←' - щоб перемiститись влiво\nНажимайте '↑' - щоб перемiститись вправо");
            while (program)
            {
                Console.WriteLine(maket);
                cannon.Print();
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    cannon.Pull(Cannon_C, column);
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    cannon.Push(Cannon_C, column);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (column != lake.GetLength(0))
                        column++;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (column != 0)
                        column--;
                }
                Console.WriteLine(Cannon_C);
            }
            Console.ReadKey();
        }
    }
}
