namespace LeetCodeProblems.Solutions
{
    // https://leetcode.com/problems/binary-search/description/
    public class Solution704
    {
        public int Search(int[] nums, int target)
        {
            var length = nums.Length;
            return DoSearch(nums, target, 0, length - 1);
        }

        private int DoSearch(int[] container, int target, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                return container[startIndex] == target ? startIndex : -1;
            }

            if (endIndex - startIndex == 1)
            {
                return container[startIndex] == target ? startIndex : container[endIndex] == target ? endIndex : - 1;
            }

            var midIndex = startIndex + (endIndex - startIndex) / 2;

            if (container[midIndex] == target)
            {
                return midIndex;
            }

            if (container[midIndex] > target)
            {
                return DoSearch(container, target, startIndex, midIndex);
            }

            return DoSearch(container, target, midIndex, endIndex);
        }
    }
}