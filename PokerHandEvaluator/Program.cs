using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandEvaluator
{
    class Program
    {
        /*
         * Suits: clubs (♣), diamonds (♦), hearts (♥) and spades (♠).
         * Cards are represented like this: [Value as String, Suit as String],
         * For example: ["3", "Diamond"], ["12", "Heart"]
         * 
         * NOTE: special values: 11 - Joker, 12 - Queen, 13 - King, 14 - Ace
         */

        /*static void print(object o)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("RankName: " + rankName);
            Console.WriteLine("Rank: " + rank);
            Console.WriteLine("Your Cards:");
            foreach (string[] card in rankCards)
            {
                Console.WriteLine("--- Value: " + card[0]);
                Console.WriteLine("--- Suit: " + card[1] ?? "none");
            }
            Console.WriteLine("------------------------");
        }*/

        static void Main(string[] args)
        {
            // Suits: club (♣), diamond (♦), heart (♥) and spade (♠).
            Room room = new Room
            {
                RoomName = "Test Room",
                CardsOnTable = new List<string[]>
                {
                    new string[]{"3", "Diamond"},
                    new string[]{"3", "Heart"}, 
                    new string[]{"2", "Spade"},
                    new string[]{"2", "Club"},
                    new string[]{"2", "Spade" }
                }
            };

            ApplicationUser user1 = new ApplicationUser
            {
                Name = "A",
                PlayerCards = new List<string[]>
                {
                    new string[]{"14", "Diamond"},
                    new string[]{"14", "Spade"},
                },
                Chips = 0
            };

            ApplicationUser user2 = new ApplicationUser
            {
                Name = "B",
                PlayerCards = new List<string[]>
                {
                    new string[]{"3", "Club"},
                    new string[]{"4", "Diamond"},
                },
                Chips = 0
            };

            ApplicationUser user3 = new ApplicationUser
            {
                Name = "C",
                PlayerCards = new List<string[]>
                {
                    new string[]{"8", "Club"},
                    new string[]{"13", "Club"},
                },
                Chips = 0
            };

            room.Chair0 = user1;
            room.Chair3 = user2;
            //room.Chair4 = user3;

            room.PotOfChair0 = 25;
            room.PotOfChair3 = 50;
            //room.PotOfChair4 = 100;


            var result = room.SpreadMoneyToWinners();

            //Console.WriteLine(room.GetPlayerHandRank(user1));

            Console.WriteLine("Done.");
            Console.ReadKey();

        }
    }
}
