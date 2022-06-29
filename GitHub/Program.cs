using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    {
        static public void Pull(char cannon, int column)
        {
            if (cannon == ' ')
            {
                for(int i = column, j = 5; j >= 0; j--)
                {

                }
            }
            else
                Console.WriteLine("\n\tПушка вже заповнена!!!");
        }
        static public void Push(char cannon, int column)
        {

        }
        static void Main(string[] args)
        {
            char Cannon = ' ';
            int Column = 0;
            bool program = true;
            Console.WriteLine("\t|ГРА З РИБКАМИ|");
            Console.WriteLine("\nНажимайте '↓' - щоб втягнути рибку у пушку\nНажимайте '↑' - щоб зкормити рибку iншiй");
            Console.WriteLine("\nНажимайте '←' - щоб перемiститись влiво\nНажимайте '↑' - щоб перемiститись вправо");
            while (program)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Pull(Cannon, Column);
                }
                if (key.Key == ConsoleKey.UpArrow)
                {

                }
                if (key.Key == ConsoleKey.RightArrow)
                {

                }
                if (key.Key == ConsoleKey.LeftArrow)
                {

                }
            }
            Console.ReadKey();
        }
    }
}
