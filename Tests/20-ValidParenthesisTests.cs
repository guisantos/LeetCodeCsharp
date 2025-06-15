using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Solution.Easy;

namespace LeetCode.Test;
public class ValidParenthesisTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([{}])", true)]
    public void IsValid_ReturnsTrueForValidParentheses(string input, bool expected)
    {
        var solver = new ValidParenthesis();
        bool result = solver.IsValid(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([{}])", true)]
    public void IsValidArray_ReturnsTrueForValidParentheses(string input, bool expected)
    {
        var solver = new ValidParenthesis();
        bool result = solver.IsValidArray(input);
        Assert.Equal(expected, result);
    }
}
