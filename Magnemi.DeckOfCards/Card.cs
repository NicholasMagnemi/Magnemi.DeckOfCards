using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Magnemi.DeckOfCards
{
    public class Card
    {
        private String _suit = null;
        private String _rank = null;
        private enum _suitsOfCards { Clubs, Spades, Hearts, Diamonds }
        private enum _rankOfCards { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

        public Card(String suit, String rank)
        {
            set_suit(suit);
            set_rank(rank);
        }

        public bool set_rank(string s)
        {
            if (Enum.TryParse<_rankOfCards>(s, out _rankOfCards rank))
            {
                _rank = rank.ToString();

                return true;
            }
            else
                return false;
        }

        public string get_rank()
        {
            if (_rank != null)
            {
                return _rank;
            }
            return "not valid rank";
        }

        public bool set_suit(string s)
        {
            if (Enum.TryParse<_suitsOfCards>(s, out _suitsOfCards suit))
            {
                _suit = suit.ToString();
                return true;
            }
            else
                return false;
        }

        public string get_suit()
        {
            if (_suit != null)
            {
                return _suit;
            }
            return "not valid suit";
        }
    }
}