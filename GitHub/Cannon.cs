using System;

namespace GitHub
{
    internal class Cannon
    {
        private char[,] lake;
        public Cannon(char[,]lake) //конструктор
        {
            this.lake = lake;
        }
        public char Pull(char fish_cannon, int column) //заповнення пушкі рибкою
        {
            if (fish_cannon == ' ')
            {
                for (int i = column, j = 4; j >= 0; j--)
                {
                    if (lake[j, column] != ' ')
                    {
                        char temp = lake[j, column];
                        lake[j, column] = ' ';
                        Console.Beep();
                        return temp;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tТут немає рибок!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tПушка вже заповнена!!!");
                Console.ResetColor();
            }
            return fish_cannon;
        }
        public char Push(char fish_cannon, int column) //вистріл рибкою
        {
            if (fish_cannon != ' ')
            {
                for (int i = column, j = 4; j >= 0; j--)
                {
                    if (lake[j, column] != ' ')
                    {
                        Console.Beep();
                        return Eat_fish(fish_cannon, lake, column, j);
                    }
                }
                lake[0, column] = fish_cannon;
                fish_cannon = ' ';
                Console.Beep();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tПушка пуста!!!");
                Console.ResetColor();
            }
            return fish_cannon;
        }
        public char Eat_fish(char fish_cannon, char[,]lake, int column, int line) //з'їдання риби
        {
            if (lake[line, column] == 'B') 
            {
                if (fish_cannon == 'm' || fish_cannon == 'M')
                {
                    lake[line, column] = ' ';
                    fish_cannon = ' ';
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nВеличезна рибка лопнула!");
                    Console.ResetColor();

                }
                else
                {
                    this.lake[line + 1, column] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[line, column] == 'b') 
            {
                if (fish_cannon == 'm' || fish_cannon == 'M')
                {
                    lake[line, column] = 'B';
                    fish_cannon = ' ';
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nВелика рибка лопнула!");
                    Console.ResetColor();
                }
                else
                {
                    this.lake[line + 1, column] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[line, column] == 'M') 
            {
                if (fish_cannon == 's')
                {
                    lake[line, column] = ' ';
                    fish_cannon = ' ';
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nТовста середня рибка лопнула!");
                    Console.ResetColor();
                }
                else
                {
                    this.lake[line + 1, column] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[line, column] == 'm') 
            { 
                if(fish_cannon == 's')
                {
                    lake[line, column] = 'M';
                    fish_cannon = ' ';
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nСередня рибка стала товстою!");
                    Console.ResetColor();
                }
                else
                {
                    this.lake[line + 1, column] = fish_cannon;
                    fish_cannon = ' ';
                }
            }
            if (lake[line, column] == 's')
            {
                this.lake[line + 1, column] = fish_cannon;
                fish_cannon = ' ';
            }
            return fish_cannon;
        }
        public void Print(ref char[,] _lake, int column, char s) //друк
        {
            if (s == ' ')
                s = '0';
            for (int i = 0; i < _lake.GetLength(0); i++)
            {
                for (int j = 0; j < _lake.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(_lake[i, j]);
                    Console.ResetColor();
                }
                Console.Write('|');
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i != column * 2; i++)
                Console.Write(' ');
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" {s}\n");
            Console.ResetColor();
        }
    }
}
