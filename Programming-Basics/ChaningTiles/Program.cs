using System;

namespace Change_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            double sizeTileWidth = double.Parse(Console.ReadLine());
            double sizeTileLenght = double.Parse(Console.ReadLine());
            double sizeBenchWidth = double.Parse(Console.ReadLine());
            double sizeBenchLength = double.Parse(Console.ReadLine());

            int areaField = sizeField * sizeField;
            double areaTile = sizeTileWidth * sizeTileLenght;
            double areaBench = sizeBenchWidth * sizeBenchLength;

            double numOfTiles = (areaField - areaBench) / areaTile;
            double workTime = numOfTiles * 0.2;

            Console.WriteLine(numOfTiles);
            Console.WriteLine(workTime);
        }
    }
}
