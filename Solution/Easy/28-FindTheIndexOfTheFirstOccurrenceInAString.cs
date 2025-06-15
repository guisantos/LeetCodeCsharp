using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy;
public class FindTheIndexOfTheFirstOccurrenceInAString
{
    //https://www.youtube.com/watch?v=0iDiUuHZE_g
    // KPM algorithm
    // Time complexity: O(n + m) where n is the length of the haystack and m is the length of the needle
    // Complex algorithm :|
    public int StrStr(string haystack, string needle)
    {
        // Step 1: Build the LPS (Longest Prefix which is also Suffix) array
        var lps = new int[needle.Length]; // lps[i] means the length of the longest proper prefix which is also suffix for needle[0..i]
        var pre = 0; // Pointer to track the prefix length

        // Start at index 1 because a single character can't have a proper prefix/suffix
        for (int i = 1; i < needle.Length; i++)
        {
            // If characters don't match, backtrack to the previous prefix length
            while (pre > 0 && needle[i] != needle[pre])
            {
                pre = lps[pre - 1]; // Try shorter prefix
            }

            // If characters match, extend the known prefix
            if (needle[pre] == needle[i])
            {
                pre++;
                lps[i] = pre; // Store the current prefix length at index i
            }
            // else lps[i] stays 0 (no prefix-suffix match)
        }

        // Step 2: Search needle in haystack using the LPS array
        var n = 0; // Pointer for position in the needle

        for (int h = 0; h < haystack.Length; h++)
        {
            // Mismatch while there’s still a prefix to fall back on
            while (n > 0 && needle[n] != haystack[h])
            {
                n = lps[n - 1]; // Fall back in the pattern (don't reset to 0)
            }

            // If characters match, move to the next character in needle
            if (needle[n] == haystack[h])
            {
                n++;
            }

            // If we've matched the entire needle, return starting index
            if (n == needle.Length)
            {
                return h - n + 1;
            }
        }

        return -1; // No match found
    }

    // Time: O(n* m) where n = haystack.Length, m = needle.Length
    // Space: O(1) (no extra memory used)
    public int StrStrBruteForce(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle)) return 0; // Edge case: empty needle returns 0
        if (needle.Length > haystack.Length) return -1;

        // Loop through haystack from index 0 to the point where needle could still fit
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            int j = 0;

            // Compare each character of needle with the corresponding part in haystack
            while (j < needle.Length && haystack[i + j] == needle[j])
            {
                j++;
            }

            // If we reached the end of needle, we found a match
            if (j == needle.Length)
            {
                return i;
            }
        }

        return -1; // No match found
    }
}
