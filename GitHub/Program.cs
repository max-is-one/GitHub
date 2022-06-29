using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    {
        static void AddFishs(ref char[,] lake)
        {
            char[] fishs = new char[5];
            Random r = new Random();
            int value;
            for(int i = 0; i < 4; i++)
            {
                value = r.Next(100);

                if (value < 30)
                {
                    fishs[i] = ' ';
                }else if(value>=30 && value <= 69)
                {
                    fishs[i] = 'm';
                }else if(value>=70 && value <= 89)
                {
                    fishs[i] = 'b';
                }
                else
                {
                    fishs[i] = 's';
                }
            }
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(lake[i,j]!=' ')
                    {
                        lake[i, j] = fishs[i];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ExploedFish");
            char[] column = new char[] { '|', '1', '|', '2', '|', '3', '|', '4', '|', '5', '|' };
            char[,] lake = new char[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    lake[i, j] = ' ';
            }
            
        }
    }
}
