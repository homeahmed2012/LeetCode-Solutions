public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var chars = new Dictionary<char, int>();
        foreach(var c in magazine)
        {
            if(chars.ContainsKey(c)) chars[c]++;
            else chars[c] = 1;
        }
        foreach(var c in ransomNote)
        {
            if(!chars.ContainsKey(c) || chars[c] < 1) return false;
            chars[c]--;
        }
        return true;
    }
}