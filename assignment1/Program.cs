using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Random random = new Random();
            int[] arr = new int[20];
            double average = 0;
            double difference = 0;

            for (int i = 0; i < 20; i++)
            {
                arr[i] = random.Next(0, 201);
                Console.WriteLine($"Element {i} is {arr[i]}");
                average += arr[i];
            }

            Console.WriteLine();
            average /= 20;
            Console.WriteLine($"The average is: {average:0.00}");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                difference = Math.Abs(arr[i] - average);
                Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
            }
        }
    }
}