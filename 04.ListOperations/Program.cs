using System;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "Add")
                {
                    integers.Add(int.Parse(commandArray[1]));
                }

                else if (commandArray[0] == "Insert")
                {
                    int number = int.Parse(commandArray[1]);
                    int index = int.Parse(commandArray[2]);

                    if (index < 0 || index >= integers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        integers.Insert(index, number);
                    }
                }

                else if (commandArray[0] == "Remove")
                {
                    int index = int.Parse(commandArray[1]);

                    if (index < 0 || index >= integers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else
                    {
                        integers.RemoveAt(index);
                    }
                }

                else if (commandArray[0] == "Shift")
                {
                    string direction = commandArray[1];
                    int count = int.Parse(commandArray[2]);

                    count %= integers.Count;

                    if (direction == "left")
                    {
                        List<int> shiftPart = integers.GetRange(0, count);
                        integers.RemoveRange(0, count);
                        integers.InsertRange(integers.Count, shiftPart);
                    }

                    else if (direction == "right")
                    {
                        List<int> shiftPart = integers.GetRange(integers.Count - count, count);
                        integers.RemoveRange(integers.Count - count, count);
                        integers.InsertRange(0, shiftPart);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
