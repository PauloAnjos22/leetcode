public class Solution {

    public string Encode(IList<string> strs) {
        var encodedString = new StringBuilder();
        for(int i = 0; i < strs.Count; i++){
            encodedString.Append(strs[i].Length);
            encodedString.Append('#');
            encodedString.Append(strs[i]);
        }

        return encodedString.ToString();
    }

    public List<string> Decode(string s) {
        var index = 0;
        var decodedString = new List<string>();

        while(index < s.Length){
            var indexOfSizeString = s.IndexOf('#', index);
            var sizeString = int.Parse(s.Substring(index, indexOfSizeString - index));
            var stringRead = s.Substring(indexOfSizeString + 1, sizeString);
            decodedString.Add(stringRead);
            index = indexOfSizeString + sizeString +  1;
        }

        return decodedString;
   }
}
