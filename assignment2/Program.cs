using System.Diagnostics.Metrics;
using System.Globalization;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[20];
            int smallest = 200;
            int counter = 0;

            for (int i = 0; i < 20; i++)
            {
                arr[i] = random.Next(0, 150);
                Console.WriteLine($"Element {i} = {arr[i]}");
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    counter = 1;
                }
                else if (arr[i] == smallest)
                {
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"smallest number = {smallest}");
            Console.WriteLine($"number of occurence = {counter}");
        }
    }
}