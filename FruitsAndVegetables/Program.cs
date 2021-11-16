using System;
using System.IO;

namespace FruitsAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitPath = @"C:\Users\opilane\samples\Fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);
            string veggiePath = @"C:\Users\opilane\samples\Veggie.txt"; ;
            string[] FruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, FruitData);
            File.WriteAllLines(veggiePath, veggieData);

        }
    }
}
