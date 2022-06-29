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
        public char Pull(char cannon, int column)
        {
            if (cannon == ' ')
            {
                for (int i = column, j = 5; j >= 0; j--)
                {
                    if (lake[column, j] != ' ')
                    {
                        char temp = lake[column, j];
                        lake[column, j] = ' ';
                        return temp;
                    }
                }
            }
            else
                Console.WriteLine("\n\tПушка вже заповнена!!!");
            return cannon;
        }
        public char Push(char cannon, int column)
        {
            if (cannon != ' ')
            {
                for (int i = column, j = 5; j >= 0; j--)
                {
                    if (lake[column, j] != ' ')
                        return Eat_fish(cannon, lake, column, j);
                }
            }
            else
                Console.WriteLine("\n\tПушка пуста!!!");
            return cannon;
        }
        public char Eat_fish(char fish_cannon, char[,]lake, int column, int line)
        {
            if (lake[column,line] == 'B') 
            {
                if (fish_cannon == 'm' || fish_cannon == 'M')
                {
                    lake[column, line] = ' ';
                    fish_cannon = ' ';
                }
                else
                {
                    this.lake[column, line + 1] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[column,line] == 'b') 
            {
                if (fish_cannon == 'm' || fish_cannon == 'M')
                {
                    lake[column, line] = 'B';
                    fish_cannon = ' ';
                }
                else
                {
                    this.lake[column, line + 1] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[column,line] == 'M') 
            {
                if (fish_cannon == 's')
                {
                    lake[column, line] = ' ';
                    fish_cannon = ' ';
                }
                else
                {
                    this.lake[column, line + 1] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[column,line] == 'm') 
            { 
                if(fish_cannon == 's')
                {
                    lake[column, line] = 'M';
                    fish_cannon = ' ';
                }
                else
                {
                    this.lake[column, line + 1] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[column, line] == 's')
            {
                this.lake[column, line + 1] = fish_cannon;
                fish_cannon = ' ';
            }
            return fish_cannon;
        }
        public void Print(int column, char s)
        {
            if (s == ' ')
                s = '0';
            for (int i = 0; i < lake.GetLength(0); i++)
            {
                for(int j = 0; j < lake.GetLength(1); j++)
                    Console.Write($"|{lake[i,j]}");
                Console.Write('|');
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i != column * 2; i++)
                Console.Write(' ');
            Console.WriteLine($" {s}\n");
        }
    }
}
