﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070916blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[,] shoe = new bool[8, 13];
            Random rnd = new Random();
            Console.Write("Vill du dra ett kort? (J/N): ");
            char switcher = Console.ReadKey().KeyChar;
            int randomSuit;
            int randomRank;
            int points = 0;
            int cards = 104;
            bool gameStatus = true;

            while (gameStatus == true)
            {
                while (switcher == 'j')
                {

                    randomSuit = rnd.Next(0, 8);
                    randomRank = rnd.Next(0, 13);


                    if (shoe[randomSuit, randomRank] == false)
                    {
                        Console.Write("\nDu drog ");
                        switch (randomSuit)
                        {
                            case 0:
                                Console.Write("hjärter ");
                                break;
                            case 1:
                                Console.Write("hjärter ");
                                break;
                            case 2:
                                Console.Write("ruter ");
                                break;
                            case 3:
                                Console.Write("ruter ");
                                break;
                            case 4:
                                Console.Write("klöver ");
                                break;
                            case 5:
                                Console.Write("klöver ");
                                break;
                            case 6:
                                Console.Write("spader ");
                                break;
                            case 7:
                                Console.Write("spader ");
                                break;
                        }

                        switch (randomRank)
                        {
                            case 0:
                                Console.WriteLine("ess");
                                break;
                            case 10:
                                Console.WriteLine("knekt");
                                break;
                            case 11:
                                Console.WriteLine("dam");
                                break;
                            case 12:
                                Console.WriteLine("kung");
                                break;
                            default:
                                Console.WriteLine(randomRank);
                                break;
                        }
                        cards--;
                        points += (randomRank + 1);
                        Console.WriteLine("Du har {0} poäng", points);
                        shoe[randomSuit, randomRank] = true;

                        if (cards == 0)
                            {
                            Console.WriteLine("\nSlut på kort! Starta om programmet om du vill köra igen.");
                            gameStatus = false;
                            }

                        else
                            {
                            Console.Write("\nVill du dra ett kort? (J/N): ");
                            switcher = Console.ReadKey().KeyChar;
                            }
                        

                        

                    }
                }

                while (switcher == 'n')
                {
                    if(points == 21)
                    {
                        Console.WriteLine("\n\nGrattis du vann!\n\nVill du köra igen?(J/N): ", points);
                    }

                    else if(points > 21)
                    {
                        Console.WriteLine("\n\nDu fick {0} poäng och förlorade, bättre lycka nästa gång.\n\nVill du köra igen?(J/N) ", points); 
                    }

                    else
                    {
                        Console.WriteLine("\n\nDu fick {0} poäng\n\nVill du köra igen? (J/N): ", points);
                    }
                    switcher = Console.ReadKey().KeyChar;
                    points = 0;
                }
            }
            
        }
    }
}
