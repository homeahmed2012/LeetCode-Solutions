public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) return true;
        
        int index = 0;
        foreach(char c in t){
            if(c == s[index]) index++;
            
            if(index == s.Length) return true;
        }
        return false;
    }
}