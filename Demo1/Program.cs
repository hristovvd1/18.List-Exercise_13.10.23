using System.Collections.Generic;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;

            double foodLeft = food;
            double hayLeft = hay;
            double coverLeft = cover;

            int thirdCount = 1;

            for (int i = 1; i <= 30; i++)
            {

                if (foodLeft > 300 && hayLeft >= foodLeft * 0.05 && coverLeft >= weight / 3)
                {
                    foodLeft -= 300;

                    if (i % 2 == 0)
                    {
                        double hayNeeded = foodLeft * 0.05;
                        hayLeft -= hayNeeded;
                    }

                    if (thirdCount == 3)
                    {
                        double coverNeeded = weight / 3;
                        coverLeft -= coverNeeded;
                        thirdCount = 0;
                    }

                    thirdCount++;
                }

                else
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodLeft / 1000):f2}, Hay: {(hayLeft / 1000):f2}, Cover: {(coverLeft / 1000):f2}.");
        }
    }
}
