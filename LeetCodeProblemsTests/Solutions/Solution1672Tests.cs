

using LeetCodeProblems.Solutions;
using NUnit.Framework;

namespace LeetCodeProblemsTests.Solutions;

public class Solution1672Tests
{

    [TestCaseSource(nameof(GetTestCases))]
    public void MaximumWealthTests(int[][] accounts, int expected)
    {
        var sut = new Solution1672();
        Assert.AreEqual(expected, sut.MaximumWealth(accounts)); 
    }

    private static IEnumerable<TestCaseData> GetTestCases()
    {
        yield return new TestCaseData(new[]{ new[] { 1, 2, 3 }, new[] { 3, 2, 1 } }, 6);
        yield return new TestCaseData(new[]{ new[] { 1,5 }, new[] { 7, 3 }, new[] { 3, 5 } }, 10);
        yield return new TestCaseData(new[]{ new[] { 2,8,7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 } }, 17);
        // Add more test cases as needed
    }
}