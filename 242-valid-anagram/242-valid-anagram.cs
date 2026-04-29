public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] chars = new int[26];
        foreach(var c in s)
        {
            chars[(int)c - (int)'a']++;
        }

        foreach(var c in t)
        {
            chars[(int)c - (int)'a']--;
            if(chars[(int)c - (int)'a'] < 0) return false;
        }
        return true;
    }
}