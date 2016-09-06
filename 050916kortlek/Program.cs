using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050916kortlek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] cardDeck = new bool[4, 13];

            Random rnd = new Random();
            int randomSuit;
            int randomRank;
            int cards = 52;

            while (cards > 0) {

            
            randomSuit = rnd.Next(0, 4);
            randomRank = rnd.Next(0, 13);

                if (cardDeck[randomSuit, randomRank] == false)
                {
                    Console.WriteLine("Tryck Enter för att ta ett kort!");
                    Console.ReadLine();

                    switch (randomSuit)
                    {
                        case 0:
                            Console.Write("Du drog hjärter ");
                            break;
                        case 1:
                            Console.Write("Du drog ruter ");
                            break;
                        case 2:
                            Console.Write("Du drog klöver ");
                            break;
                        case 3:
                            Console.Write("Du drog spader ");
                            break;
                        default:
                            Console.WriteLine(string.Empty);
                            break;
                    }

                    switch (randomRank) {
                        case 0:
                            Console.WriteLine("ess!");
                            break;
                        case 11:
                            Console.WriteLine("knekt!");
                            break;
                        case 12:
                            Console.WriteLine("dam!");
                            break;
                        case 13:
                            Console.WriteLine("kung!");
                            break;
                        default:
                            Console.WriteLine(randomRank + '!');
                            break;

                        cardDeck[randomSuit, randomRank] = true;
                        
                    }
                        
                        cards--;
                        Console.WriteLine("Det finns " + cards + " kort kvar i kortleken.");
                }
                
            
            }


            
            
                
            

        }
    }
}
