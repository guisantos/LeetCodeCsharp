using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
internal class AddBinary
{
    // https://www.youtube.com/watch?v=keuWJ47xG8g
    // Time Complexity	O(max(n, m))
    // Space Complexity O(max(n, m))
    public string AddBinarySolution(string a, string b)
    {
        // Use StringBuilder for efficient string manipulation
        StringBuilder result = new StringBuilder();

        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0; // Carry for binary addition

        // Loop while either pointer is in range or carry is non-zero
        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry; // Start with the carry from the previous iteration

            // If a still has digits, add the binary value of a[i]
            if (i >= 0)
            {
                sum += a[i] - '0'; // Convert char '1'/'0' to int 1/0
                i--;
            }

            // If b still has digits, add the binary value of b[j]
            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            // Append the current bit to result (0 or 1)
            result.Append(sum % 2);

            // Update carry (1 if sum is 2 or 3, else 0)
            carry = sum / 2;
        }

        // Reverse the result since we built it backwards
        StringBuilder final = new StringBuilder(result.Length);
        for (int k = result.Length - 1; k >= 0; k--)
        {
            final.Append(result[k]);
        }

        return final.ToString();
    }
}