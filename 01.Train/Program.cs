namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonMaxCapacity = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();

                if (commands[0] == "Add")
                {
                    int passengers = int.Parse(commands[1]);

                    passengersInWagons.Add(passengers);
                }

                else
                {
                    int passengers = int.Parse(commands[0]);

                    for (int i = 0; i < passengersInWagons.Count; i++)
                    {
                        if (passengersInWagons[i] + passengers <= wagonMaxCapacity)
                        {
                            passengersInWagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", passengersInWagons));
        }
    }
}
