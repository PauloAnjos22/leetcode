public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var auxArray = new int[26];
        for(int i = 0; i < s.Length; i++)
            auxArray[s[i] - 'a']++; // adiciono no array na posicao correta do alfabeto
        

        for(int i = 0; i < t.Length; i++){
            auxArray[t[i] - 'a']--;
            if(auxArray[t[i] - 'a'] < 0) // se um valor negativo apareceu, significa que nao houve incremento suficiente para o caractere no laço anterior
                return false;
        }

        for(int i = 0; i < auxArray.Length; i++){
            if(auxArray[i] != 0)
                return false;
        }

        return true;
    }
}
