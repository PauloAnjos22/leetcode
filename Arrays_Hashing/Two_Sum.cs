public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionary = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int difference = target - nums[i];

            if(dictionary.ContainsKey(difference))
                return new int[2]{dictionary[difference], i};

            dictionary.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}
