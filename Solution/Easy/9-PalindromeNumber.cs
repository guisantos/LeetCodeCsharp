using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
public class PalindromeNumber
{
    //https://www.youtube.com/watch?v=OlTk8wM48ww
    // palindrome number is a number that reads the same backward as forward
    // e.g. 121, 12321,
    // 0, -121 is not a palindrome because it reads as 121-
    // // 10, 100, 1000 is not a palindrome because it reads as 01, 001, 0001
    public bool IsPalindrome(int x)
    {
        // negative number is never palindrome
        // a number finished with 0 is not a palindrome
        if (x < 0 || x != 0 && x % 10 == 0)
        {
            return false;
        }

        int half = 0;
        // e.g 1221 
        while (x > half)
        {
            // half = (0 * 10 = 0) + (1221 % 10 = 1)
            // half = 0 + 1 = 1
            // half = (1 * 10 = 10) + (122 % 10 = 2)
            // half = 10 + 2 = 12
            half = half * 10 + x % 10;
            // x = 1221 / 10 = 122
            // we basically moved the 1 from 1221 to the other half
            // x = 122 / 10 = 12
            x /= 10;
        }

        // if the length of the number is odd, we can get rid of the middle digit by half / 10
        return x == half || x == half / 10;
    }
}
