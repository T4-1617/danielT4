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

            //Creates ints for random card suits, random card ranks, a card counter and a point counter
            int randomSuit;
            int randomRank;
            int cards = 1;
            int points = 0;

            //loop that stops when there are no cards left in the card deck
            while (cards <= 52) {

            //Gathers two random numbers from 0 to 4 and 0 to 13
            randomSuit = rnd.Next(0, 4);
            randomRank = rnd.Next(0, 13);

                if (cardDeck[randomSuit, randomRank] == false)//Enters if the card is unused/false
                {
                    Console.WriteLine("Tryck Enter för att ta ett kort!");
                    Console.ReadLine();
                    Console.Write("Ditt kort nummer " + cards);

                    switch (randomSuit)//Prints the suit that is picked by the Random Number Generator
                    {
                        case 0:
                            Console.Write(" är hjärter ");
                            break;
                        case 1:
                            Console.Write(" är ruter ");
                            break;
                        case 2:
                            Console.Write(" är klöver ");
                            break;
                        case 3:
                            Console.Write(" är spader ");
                            break;
                        default:
                            Console.WriteLine(string.Empty);
                            break;
                    }

                    switch (randomRank)//Prints the card rank that is picked by the Random Number Generator
                    {
                        case 0:
                            Console.Write("ess");
                            break;
                        case 10:
                            Console.Write("knekt");
                            break;
                        case 11:
                            Console.Write("dam");
                            break;
                        case 12:
                            Console.Write("kung");
                            break;
                        default:
                            Console.Write(randomRank+1);
                            break;
                    }
                        points += randomRank+1;
                        Console.WriteLine(" och du har " + points + " poäng!");
                        cardDeck[randomSuit, randomRank] = true;//Changes the value of the used card from false to true
                        cards++;//Adds 1 to the card counter
                        Console.WriteLine("Det finns " + (53-cards) + " kort kvar i kortleken.");//Prints the remaining cards in the card deck
                }
                
            
            }


            
            
                
            

        }
    }
}
