public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>();
        var map = new Dictionary<int, int>();

        foreach(var num in nums){
            hash.Add(num);
        }
        
        var numSequence = 0;
        foreach(var num in nums){
            numSequence = num;
            if(!hash.Contains(numSequence - 1)){ // Se nao possuir elemento à esquerda, o valor é o início de uma sequencia
                map[num] = 1;
                while(true){
                    numSequence++;
                    if(hash.Contains(numSequence))
                        map[num]++;
                    else
                        break; // Não possui mais sequencias
                }
            }
            else
                continue;
        }
        
        var maxSequence = 0;
        foreach(var item in map){
            if(maxSequence < item.Value)
                maxSequence = item.Value;
        }

        return maxSequence;
    }
}
