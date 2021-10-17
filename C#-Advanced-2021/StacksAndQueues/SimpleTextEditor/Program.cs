using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder emptyString = new StringBuilder();

            Stack<string> undoString = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string operation = command[0];

                if (operation == "1")
                {
                    undoString.Push(emptyString.ToString());

                    string newText = command[1];

                    emptyString.Append(newText);
                }
                else if (operation == "2")
                {
                    undoString.Push(emptyString.ToString());

                    int eraseLast = int.Parse(command[1]);

                    while (eraseLast > 0)
                    {
                        emptyString.Remove(emptyString.Length - 1, 1);
                        eraseLast--;
                    }
                }
                else if (operation == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(emptyString[index - 1]);
                }
                else if (operation == "4")
                {
                    emptyString.Clear();
                    emptyString.Append(undoString.Pop());
                }
            }
        }
    }
}
