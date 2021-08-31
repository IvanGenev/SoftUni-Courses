using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (!command.Contains("Done"))
            {
                string[] commandArgs = command.Split(" | ");
                string commandName = commandArgs[0];
                string bookName = commandArgs[1];

                if (commandName.Contains("Add"))
                {
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                }
                else if (commandName.Contains("Take"))
                {
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                    
                }
                else if (commandName.Contains("Insert"))
                {
                    books.Add(bookName);
                }
                else if (commandName.Contains("Swap"))
                {
                    string bookName2 = commandArgs[2];

                    if (books.Contains(bookName) && books.Contains(bookName2))
                    {
                        int index1 = books.IndexOf(bookName);
                        int index2 = books.IndexOf(bookName2);
                        books.RemoveAt(index1);
                        books.Insert(index1, bookName2);
                        books.RemoveAt(index2);
                        books.Insert(index2, bookName);
                    }
                    
                }
                else if (commandName.Contains("Check"))
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index <= books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
