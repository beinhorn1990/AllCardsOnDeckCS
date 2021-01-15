using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var suits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var deck = new List<string>();
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    deck.Add($"{rank} of {suit}");
                }

            }
        }
    }
}