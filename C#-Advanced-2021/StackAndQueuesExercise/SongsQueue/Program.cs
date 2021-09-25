using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else if (command.Contains("Add"))
                {
                    int index = command.IndexOf(' ');
                    string songName = command.Substring(index + 1);

                    if (queue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songName);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
