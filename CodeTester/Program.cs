using System;
using System.Collections.Generic;

namespace Shifr
{
    enum Suite
    {
        Diamonds,
        Hearts,
        Clubs,
        Spades
    }

    enum Rank
    {
        Ace,
        King,
        Queen,
        Jack
    }

    class Card
    {
        public Rank Rank;
        public Suite Suite;
        public override string ToString()
        {
            string result= $"{Rank} {Suite}";
            return result;
            //return Rank.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Card a = new Card();
            a.Suite = Suite.Spades;
            a.Rank = Rank.Queen;
            Card b = new Card();
            b.Suite = Suite.Clubs;
            b.Rank = Rank.King;

            List<Card> list = new List<Card>();
            list.Add(a);
            list.Add(b);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}