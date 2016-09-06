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
            bool[,] cardDeck = new bool[4, 13];//Creates a 2-dimensional array with false bools

            Random rnd = new Random();//Random number generator

            //Creates ints for random card suits, random card ranks and a card counter
            int randomSuit;
            int randomRank;
            int cards = 52;

            //loop that stops when there are no cards left in the card deck
            while (cards > 0) {

            //Gathers two random numbers from 0 to 4 and 0 to 13
            randomSuit = rnd.Next(0, 4);
            randomRank = rnd.Next(0, 13);

                if (cardDeck[randomSuit, randomRank] == false)//Enters if the card is unused/false
                {
                    Console.WriteLine("Tryck Enter för att ta ett kort!");
                    Console.ReadLine();

                    switch (randomSuit)//Prints the suit that is picked by the Random Number Generator
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

                    switch (randomRank)//Prints the card rank that is picked by the Random Number Generator
                    {
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
                            Console.WriteLine(randomRank);
                            break;
                    }
                        cardDeck[randomSuit, randomRank] = true;//Changes the value of the used card from false to true
                        cards--;//subtracts 1 from the card counter
                        Console.WriteLine("Det finns " + cards + " kort kvar i kortleken.");//Prints the remaining cards in the card deck
                }
                
            
            }


            
            
                
            

        }
    }
}
