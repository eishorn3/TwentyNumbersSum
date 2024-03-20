namespace TwentyNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int all = 0;
            int[] twentyNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i <= twentyNumbers.Length - 1; i++)
            {
                if (twentyNumbers[i] % 2 == 0)
                {
                    Console.Write(twentyNumbers[i] + "  ");
                }

                all = sum += twentyNumbers[i];
            }
            Console.WriteLine($"\nThe sum of it all is: {all}");
        }
    }
}
