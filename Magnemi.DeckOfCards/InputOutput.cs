using System;

namespace Magnemi.DeckOfCards
{
    internal class InputOutput
    {
        public InputOutput() { }

        public String readUserInput(string message)
        {
            Console.WriteLine("\n" + message.Trim() + "\n");
            return Console.ReadLine();
        }

        public void displayMessage(string message)
        {
            Console.WriteLine("\n" + message.Trim() + "\n");
        }
    }
}

