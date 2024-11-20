using System.Linq;

namespace min
{

     internal class Program
    {
        static char ReadInput()
        {
            char selection = '\0';
            Console.Write("Enter your selection: ");
            selection = char.Parse(Console.ReadLine().ToLower());

            return selection;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Search By Number To Find Index");
            Console.WriteLine("C - To Clear A List");
            Console.WriteLine("Q - Quit");
            Console.WriteLine("\n---------------------");
        }

        static void PrintList(List<int> list)
        {
            Console.Write("[ ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("]");
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            do
            {
                DisplayMenu();
                char selection = ReadInput();

                switch (selection)
                {
                    case 'p':
                        if(list.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            PrintList(list);
                        }
                        break;
                    case 'a':
                        Console.Write("Enter value: ");

                        int value = int.Parse(Console.ReadLine());
                        bool isFound = false;
                        for (global::System.Int32 i = 0; i < list.Count; i++)
                        {
                            if(list[i] == value)
                            {
                                isFound = true;
                                break;
                            }
                        }
                        if(!isFound)
                        {
                            list.Add(value);
                            Console.WriteLine($"{value} added");
                        }
                        break;
                    case 'm':
                        break;
                    case 's':

                        int smallest = list[0];
                        for (global::System.Int32 i = 0; i < list.Count; i++)
                        {
                            if (list[i] < smallest)
                            {
                                smallest = list[i];
                            }
                        }
                        Console.WriteLine($"smallest: {smallest}");

                        break;
                    case 'l':
                        Console.WriteLine("l");
                        break;
                    case 'f':
                        Console.WriteLine("f");
                        break;
                    case 'c':
                        Console.WriteLine("c");
                        break;
                    case 'q':
                        Console.WriteLine("q");
                        Console.WriteLine("good bye");
                        break;
                    default:
                        Console.WriteLine("another");
                        break;

                }

            } while (true);
        }
    }
    
}
