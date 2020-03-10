using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char [8, 8];


        for(int i = 0; i < 8; i++)
            {
                for (int j = 0; j< 8; j++)
                {

                    board[i, j] = '_';
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    Console.Write(board[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            char T = 'W';

            for(int k = 0; k < 64; k++)
            {
                Console.WriteLine("\n\nEnter Row Col (0-7) ");
                int r = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                board[r, c] = T;
                Console.Clear();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {

                        if (board[i, j] == 'W')
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                        }

                        else if (board[i, j] == 'B')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                        }
                       else
                            Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Write(board[i, j]);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
                if (T == 'W')
                {
                    T = 'B';

                }
                else
                    T = 'W';




            }




            Console.ReadKey();

        }
    }
}
