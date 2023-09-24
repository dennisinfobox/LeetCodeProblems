namespace LeetCodeProblems.Solutions
{
    public class Solution1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(r=>r.Sum());
        }
    }
}