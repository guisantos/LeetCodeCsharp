using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test;
public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "interspecies", "interstellar", "interstate" }, "inters")]
    [InlineData(new string[] { "throne", "dungeon" }, "")]
    [InlineData(new string[] { "throne", "throne" }, "throne")]
    [InlineData(new string[] { "a" }, "a")]
    [InlineData(new string[] { }, "")]
    public void LongestCommonPrefix_ReturnsExpected(string[] input, string expected)
    {
        var solver = new LongestCommonPrefix();

        string result = solver.LongestCommonPrefixSolution(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "interspecies", "interstellar", "interstate" }, "inters")]
    [InlineData(new string[] { "throne", "dungeon" }, "")]
    [InlineData(new string[] { "throne", "throne" }, "throne")]
    [InlineData(new string[] { "a" }, "a")]
    [InlineData(new string[] { }, "")]
    public void LongestCommonPrefix2_ReturnsExpected(string[] input, string expected)
    {
        var solver = new LongestCommonPrefix();

        string result = solver.LongestCommonPrefixSolution2(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void LongestCommonPrefix_NullInput_ReturnsEmptyString()
    {
        var solver = new LongestCommonPrefix();

        string result = solver.LongestCommonPrefixSolution(null);

        Assert.Equal(string.Empty, result);
    }
}
