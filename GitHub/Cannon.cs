using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Cannon
    {
        private char[,] lake;
        public Cannon(char[,]lake)
        {
            this.lake = lake;
        }
        public void Pull(char cannon, int column)
        {
            if (cannon == ' ')
            {
                for (int i = column, j = 5; j >= 0; j--)
                {

                }
            }
            else
                Console.WriteLine("\n\tПушка вже заповнена!!!");
        }
        public void Push(char cannon, int column)
        {
            if (cannon != ' ')
            {
                for (int i = column, j = 5; j >= 0; j--)
                {

                }
            }
            else
                Console.WriteLine("\n\tПушка пуста!!!");
        }
        public void Print()
        {
            for (int i = 0; i < lake.GetLength(0); i++)
            {
                for(int j = 0; j < lake.GetLength(1); j++)
                    Console.Write($"|{lake[i,j]}");
                Console.Write('|');
                Console.WriteLine();
            }
        }
    }
}
