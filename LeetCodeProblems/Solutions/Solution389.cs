namespace LeetCodeProblems.Solutions;

public class Solution389
{
    public char FindTheDifference(string s, string t)
    {
        var orderedList = s.OrderBy(r => r).ToList();
            
        foreach (var c in t)
        {
            var index = orderedList.BinarySearch(c);
            if (index < 0)
                return c;
            orderedList.RemoveAt(index);
        }
        return '\0';
    }
}