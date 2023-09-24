

using LeetCodeProblems.Solutions;
using NUnit.Framework;

namespace LeetCodeProblemsTests.Solutions;

public class Solution704Tests
{

    [TestCaseSource(nameof(GetTestCases))]
    public void MaximumWealthTests(int[] nums, int target, int expected)
    {
        var sut = new Solution704();
        Assert.AreEqual(expected, sut.Search(nums, target)); 
    }

    private static IEnumerable<TestCaseData> GetTestCases()
    {
        yield return new TestCaseData( new[] { -1, 0, 3, 5, 9, 12 }, 9, 4);
        yield return new TestCaseData( new[] { -1, 0, 3, 5, 9, 12 }, 2, -1);
        // Add more test cases as needed
    }
}