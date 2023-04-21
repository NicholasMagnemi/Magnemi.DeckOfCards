using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace Magnemi.DeckOfCards
{
    public class DeckOfCards
    {
        private Card[] _deck = null;

        public DeckOfCards()
        {
            InputOutput inputOutput = new InputOutput();

            set_deck();
            fillDeck();

            String message = "Show filled deck: \n\n ";
            inputOutput.displayMessage(message + get_deck());

            shuffleCards();

            message = "Show shuffled deck: \n\n " + get_deck();
            inputOutput.displayMessage(message + get_deck());

        }

        public bool set_deck()
        {
            _deck = new Card[52];
            return true;
        }

        public String get_deck()
        {
            String deckOfCards = "";
            for (int count = 0; count < 52; count++)
            {
                deckOfCards += _deck[count].get_rank() + " of " + _deck[count].get_suit() + "\n\n";
            }
            return deckOfCards;
        }

        public Card[] fillDeck()
        {
            String[] suitTypes = { "Hearts", "Diamonds", "Spades", "Clubs" };
            String[] rankTypes = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            int count = 0;

            foreach (String suit in suitTypes)
            {
                foreach (String rank in rankTypes)
                {
                    _deck[count] = new Card(suit, rank);
                    count++;
                }
            }
            return _deck;

        }

        public void shuffleCards()
        {
            Card[] tempDeck = new Card[52];

            Random random = new Random();

            for (int count = 0; count < _deck.Length; count++)
            {
                int randomIndex = random.Next(0, _deck.Length);
                tempDeck[count] = _deck[randomIndex];
            }
            _deck = tempDeck;

        }
    }
}