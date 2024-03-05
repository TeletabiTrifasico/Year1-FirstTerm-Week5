using System.Diagnostics.Metrics;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Entre a number (0=stop): ");
                int input = Convert.ToInt32(Console.ReadLine());
                arr[i] = input;
                if (input == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Enter a searchvalue: ");
            int searchvalue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < arr.Length;i++) 
            {
                if (arr[i] == searchvalue)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Number of occurences of searchvalue ({searchvalue}) is: {counter}");
        }
    }
}