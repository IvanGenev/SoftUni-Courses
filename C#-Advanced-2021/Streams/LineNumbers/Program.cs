using System;
using System.IO;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] lines = await File.ReadAllLinesAsync("input.txt");
            int count = 1;

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{i + 1}. {lines[i]}";
            }

            await File.WriteAllLinesAsync("output.txt", lines);


            //using (StreamReader str = new StreamReader("input.txt"))
            //{
            //    string line = await str.ReadLineAsync();

            //    using (StreamWriter wrt = new StreamWriter("output.txt"))
            //    {
            //        int count = 1;

            //        while (line != null)
            //        {
            //            await wrt.WriteLineAsync($"{count}. {line}");

            //            line = await str.ReadLineAsync();
            //        }
            //    }
            //}
        }
    }
}
