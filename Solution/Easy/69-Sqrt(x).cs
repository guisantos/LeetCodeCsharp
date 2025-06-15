using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
public class Sqrt_x_
{
    // https://www.youtube.com/watch?v=1_4xlky3Y2Y
    public int MySqrt(int x)
    {
        if (x < 2) return x; // early return for 0 or 1

        int left = 1;
        int right = x;

        while (left <= right)
        {
            // to avoid overflow, use this formula
            int mid = left + (right - left) / 2;
            int div = x / mid;

            if (mid == div)
            {
                return mid; // perfect square
            }

            if (mid < div)
            {
                left = mid + 1; // mid^2 is too small
            }
            else
            {
                right = mid - 1; // mid^2 is too large
            }
        }

        return right; // floor of sqrt(x)
    }

    public int MySqrtNewtons(int x)
    {
        // handle base cases directly
        if (x < 2)
            return x;

        // use long to prevent overflow during multiplication
        long guess = x;

        // iterate until guess * guess is no longer greater than x
        while (guess * guess > x)
        {
            // Newton's formula:
            // next_guess = (guess + x / guess) / 2
            // This moves the guess closer to the actual square root
            guess = (guess + x / guess) / 2;
        }

        // return the integer part of the square root
        return (int)guess;
    }

    public int MySqrtBruteForce(int x)
    {
        int i = 1;
        while (i <= x / i)
        {
            i++;
        }
        return i - 1;
    }
}
