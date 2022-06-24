using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For test case (3, 9), the answer is: " + squareCounter(3, 9));
            Console.WriteLine("For test case (17, 24), the answer is: " + squareCounter(17, 24));
            Console.WriteLine("For test case (1, 1000000000), the answer is: " + squareCounter(1, 1000000000));
        }
    }
    public class problem1
    {
        public static int squareCounter(int a, int b)
        {
            List<int> squaresInRange = new List<int>();
            for (int i=a;i<=b;i++)
            {
                if (Math.Sqrt(i)%1==0)
                {
                    squaresInRange.Add(i);
                }
            }
            return squaresInRange.Count();
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