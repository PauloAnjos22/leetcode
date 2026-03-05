public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var sufix = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++){
            if(i == 0 )
                prefix[i] = 1;
            else
                prefix[i] = nums[i - 1] * prefix[i-1];
        }

        for(int i = nums.Length; i > 0; i--){
            if(i == nums.Length)
                sufix[i - 1] = 1;
            else
                sufix[i - 1] = nums[i] * sufix[i];
        }
        
        var result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            result[i] = prefix[i] * sufix[i];
        }

        return result;
    }
}
