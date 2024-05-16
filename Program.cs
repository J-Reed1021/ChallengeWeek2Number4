namespace ChallengeWeek2Number4
{
    internal class ChallengeNumber4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}
