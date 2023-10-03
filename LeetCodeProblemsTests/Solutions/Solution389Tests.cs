

using LeetCodeProblems.Solutions;
using NUnit.Framework;

namespace LeetCodeProblemsTests.Solutions;

public class Solution389Tests
{

    [TestCase("abcd", "abcde", 'e')]
    [TestCase("", "y", 'y')]
    [TestCase("a", "aa", 'a')]
    public void MaximumWealthTests(string s, string t, char expected)
    {
        var sut = new Solution389();
        Assert.AreEqual(expected, sut.FindTheDifference(s, t)); 
    }
}