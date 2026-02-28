public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            var alphabet = new int[26];

            for(int i = 0; i < str.Length; i++)
                alphabet[str[i] - 'a']++;

            var indexDictionary = new StringBuilder();

            for(int i = 0; i < alphabet.Length; i++)
            {
                indexDictionary.Append(alphabet[i]);
                indexDictionary.Append('#');
            }

            string mapKey = indexDictionary.ToString();
            if(!map.ContainsKey(mapKey))
                map.Add(mapKey, new List<string>()); // o dicionario é string - List<string>

            map[mapKey].Add(str);
        }

        return map.Values.ToList();
    }
}
