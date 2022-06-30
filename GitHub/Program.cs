using System;

namespace GitHub
{
    internal class Program
    {
        public static void End(int count_progres)
        {
            Console.WriteLine("End");
            Console.WriteLine($"\n\tYour score {count_progres}");
        }
        static void Game()
        {
            int count = 0, fish_count = 0, count_progres = 0;
            string maket_1 = "___________";
            string maket_2 = "|1|2|3|4|5|\t";
            char[,] lake = new char[5, 5];
            FishSpawner fishSpawner = new FishSpawner();
            for (int i = 0; i < lake.GetLength(0); i++)
            {
                for (int j = 0; j < lake.GetLength(1); j++)
                    lake[i, j] = ' ';
            }
            Cannon cannon = new Cannon(lake);
            //lake[0, 3] = 's';
            //lake[1, 4] = 's';
            //lake[2, 0] = 'M';
            //lake[4, 0] = 'm';

            char Cannon_C = ' ';
            int column = 0;

            Console.WriteLine("\t|ГРА З РИБКАМИ|");
            Console.WriteLine("\nНажимайте '↓' - щоб втягнути рибку у пушку\nНажимайте '↑' - щоб зкормити рибку iншiй");
            Console.WriteLine("\nНажимайте '←' - щоб перемiститись влiво\nНажимайте '→' - щоб перемiститись вправо");


            while (true)
            {
                for (int i = 0; i < lake.GetLength(0); i++) //fish_count
                {
                    for (int j = 0; j < lake.GetLength(1); j++)
                        if (lake[i, j] != ' ')
                            fish_count++;
                }
                if (count == 2 || fish_count < 4) //spawn fishs
                {
                    count = 0;
                    fishSpawner.AddFishs(ref lake);
                }
                if (fish_count == 25)
                {
                    End(count_progres);
                    break;
                }
                fish_count = 0;

                Console.WriteLine("\n" + maket_1);
                Console.WriteLine(maket_2 + count_progres);
                cannon.Print(ref lake, column, Cannon_C);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    Cannon_C = cannon.Pull(Cannon_C, column);
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Cannon_C = cannon.Push(Cannon_C, column);
                    count++;
                    count_progres++;
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (column != lake.GetLength(0) - 1)
                        column++;
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (column != 0)
                        column--;
                    Console.Clear();
                }
                 count_progres.ToString();

                
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "\t|ГРА З РИБКАМИ|";
            Game();
            Console.ReadKey();
        }
    }
}
