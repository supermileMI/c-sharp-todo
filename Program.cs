using System;
using System.Collections.Generic;

namespace todo
{
    class Program
    {
        const string EXIT = "EXIT";
        const string LIST = "LIST";
        static void Main(string[] args)
        {
            
            var _items = new List<string>();
            Console.WriteLine();
            Console.WriteLine("Simple todo list");
            Console.WriteLine("Available commands: list, exit");

            string userInput = "";
            while (!userInput.Equals(EXIT, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please enter an item: ");
                userInput = Console.ReadLine();
                if (userInput.Equals(LIST, StringComparison.OrdinalIgnoreCase)) {
                    Console.WriteLine("The list currently contains: ");
                    Console.WriteLine(string.Join(", ", _items));
                } else {
                    _items.Add(userInput);
                }
            }

            Console.WriteLine("Bye! :)");
        }
    }
}
