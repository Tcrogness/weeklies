using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepping squares...");
            List<int> sqs = new List<int>();
            for (int j=1; j<31623; j++)
            {
                sqs.Add(j * j);
            }
            Console.WriteLine("Please hit any key to execute tests (one by one).");
            Console.ReadKey();
            Console.WriteLine("For test case (3, 9), the answer is: " + problem1.squareCounter(3, 9, sqs));
            Console.ReadKey();
            Console.WriteLine("For test case (17, 24), the answer is: " + problem1.squareCounter(17, 24, sqs));
            Console.ReadKey();
            Console.WriteLine("For test case (1, 1_000_000_000), the answer is: " + problem1.squareCounter(1, 1000000000, sqs));
        }
    }
    public class problem1
    {
        public static int squareCounter(int a, int b, List<int> c)
        {
            int sqrCount = 0;
            foreach (int i in c)
            {
                if (a<=i && i<=b)
                {
                    sqrCount++;
                }
            }
            return sqrCount;
            /*
            List<int> squaresInRange = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    squaresInRange.Add(i);
                }
            }
            return squaresInRange.Count();
            */
            /*
            int squaresInRange = 0;
            for (int i = a; i <= b; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    squaresInRange += 1;
                }
            }
            return squaresInRange;
            */
        }
    }
}
/*
Watson likes to challenge Sherlock's math ability. He will provide a starting and ending value describing a range of integers. Sherlock must determine the number of square integers within that range, inclusive of the endpoints (note that a square integer is an integer which is the square of an integer,
e.g. 1, 4, 9, 16, 25, 36, 49).
For example, the range is a=24 and b=49, inclusive. There are three square integers in the range: 25, 36 and 49.
Complete the squares function that returns an integer representing the number of square integers in the inclusive range from a to b.
Examples
<code>squares(3, 9) ➞ 2
squares(17, 24) ➞ 0
squares(1, 1000000000) ➞ 31622
</code>Notes
Your solution must solve each problem in 1 second or less.
*/