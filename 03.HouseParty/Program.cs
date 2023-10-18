namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] nextCommmands = Console.ReadLine().Split();
                string name = nextCommmands[0];

                if (nextCommmands.Length == 3)
                {
                    if (guestList.Exists(x => x == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                    else
                    {
                        guestList.Add(name);
                    }
                }

                else if (nextCommmands.Length == 4)
                {
                    if (guestList.Exists(x => x == name))
                    {
                        guestList.Remove(name);
                    }

                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
