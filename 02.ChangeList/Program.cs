namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandsArray = commands.Split();

                if (commandsArray[0] == "Delete")
                {
                    int element = int.Parse(commandsArray[1]);
                    numbers.RemoveAll(x => x == element);
                }

                else if (commandsArray[0] == "Insert")
                {
                    int element = int.Parse(commandsArray[1]);
                    int index = int.Parse(commandsArray[2]);

                    numbers.Insert(index, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}