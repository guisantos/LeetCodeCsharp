using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class PlusOne
{
    //https://www.youtube.com/watch?v=RQAQA1FH_F4
    public int[] PlusOneSolution(int[] digits)
    {
        // iterate through the list from the end to the beginning
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            // if value is not 9 add + 1 and return
            if (digits[i] != 9)
            {
                digits[i] += 1;
                return digits;
            }

            // if it's 9 add 0 and iterate again
            digits[i] = 0;
        }

        // if the first number is 9, we didn't find any other number different from 9
        // create a new array with 1 extra length
        // add 1 to the first number
        // copy the rest of the array starting at index 0 (which all numbers should be 0)
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        Array.Copy(digits, 0, result, 1, digits.Length);

        return result;
    }
}
