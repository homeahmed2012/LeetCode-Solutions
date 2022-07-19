public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var charMap = new int[130];
        for(int i = 0; i < s.Length; i++){
            if(charMap[(int)s[i]] == 0){
                charMap[(int)s[i]] = (int)t[i]; 
            }else if(charMap[(int)s[i]] != (int)t[i]) {
                return false;
            }
        }
        
        var charMap2 = new int[130];
        for(int i = 0; i < t.Length; i++){
            if(charMap2[(int)t[i]] == 0){
                charMap2[(int)t[i]] = (int)s[i]; 
            }
            else if(charMap2[(int)t[i]] != (int)s[i]) {
                return false;
            }
        }
        
        return true;
    }
}