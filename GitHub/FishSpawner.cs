using System;

namespace GitHub
{
    class FishSpawner
    {
        public void AddFishs(ref char[,] lake)
        {
            //lake = _lake;
            char[] fishs = new char[5];
            Random r = new Random();
            int value;
            for (int i = 0; i < fishs.Length; i++)
            {
                value = r.Next(100);

                if (value < 20)
                {
                    fishs[i] = ' ';
                }
                else if (value >= 30 && value <= 64)
                {
                    fishs[i] = 'm';
                }
                else if (value >= 65 && value <= 89)
                {
                    fishs[i] = 'b';
                }
                else
                {
                    fishs[i] = 's';
                }
            }
            for (int i = 0; i < lake.GetLength(0); i++)
            {
                for (int j = 0; j < lake.GetLength(1); j++)
                {
                    if (lake[j, i] == ' ')
                    {
                        lake[j, i] = fishs[i];
                        break;
                    }
                }
            }
        }
    }
}
