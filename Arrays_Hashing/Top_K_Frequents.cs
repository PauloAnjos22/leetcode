public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach(var item in nums){
            if(map.ContainsKey(item))
                map[item]++;
            else
                map[item] = 1;
        }
            
        
        var sortedMap = map.OrderByDescending(key => key.Value);
        int count = 0;
        var topFrequents = new int[k];

        foreach(var item in sortedMap){
            topFrequents[count] = item.Key;
            count++;
            if(count == k)
                break;
        }

        return topFrequents;
    }
}
