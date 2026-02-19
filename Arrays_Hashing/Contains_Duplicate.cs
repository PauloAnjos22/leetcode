public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new List<int>();
        foreach (var num in nums)
        {
            if (seen.Contains(num)) 
                return true;
            else
                seen.Add(num);
        }
        return false;
    }
}