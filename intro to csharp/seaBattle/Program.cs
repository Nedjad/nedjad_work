using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seaBattle
{
    class Program
    {

        static void Main(string[] args)
        {
            RunUserCode();

            Console.ReadLine();
        }

            static int[,] sea;

            static int battleShip = 2;
            static int cruiser = 3;
            static int submarine = 4;
            static int rowingBoat = 5;
            static int seaSize = 10;
            static int emptSea = 0;
            static int row;
            static int column;
            static string blankRow;

            static void RunUserCode()
            {
                
                sea = new int[seaSize, seaSize];

                blankRow = new string(Char.Parse(" "), (seaSize * 2) + 2);
                
                sea[0, 5] = battleShip;
                sea[2, 7] = battleShip;
                sea[0, 0] = cruiser;
                sea[2, 0] = cruiser;
                sea[4, 3] = cruiser;
                sea[5, 6] = submarine;
                sea[8, 8] = rowingBoat;
                
                DrawGameBoard();

            }
            private static void DrawGameBoard()

            {

                DrawColumnHeaders();

                for (row = emptSea; row < seaSize; row++)
                {
                    Console.Write(Environment.NewLine);
                    string rowHeader = row.ToString() + " ";

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(rowHeader);
                    Console.ResetColor();

                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    for (column = emptSea; column < seaSize; column++)
                    {

                        int cellContent = sea[column, row];

                        if (cellContent > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(cellContent + " ");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        else
                        {
                            Console.Write(cellContent + " ");
                        }
                    }

                    Console.Write(Environment.NewLine);
                    Console.Write(blankRow);
                    Console.ResetColor();

                }
                Console.Write(Environment.NewLine);
            }



            private static void DrawColumnHeaders()
            {

                Console.WriteLine();
                string Header = "  ";
                Console.Write(Header);

                for (row = emptSea; row < seaSize; row++)
                {
                    string rowHeader = row.ToString() + " ";
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(rowHeader);
                    Console.ResetColor();
                }

            }

        }

    }



