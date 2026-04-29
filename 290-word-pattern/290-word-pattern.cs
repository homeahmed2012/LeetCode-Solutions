var result = new Solution().WordPattern("abba", "dog cat cat dog");
System.Console.WriteLine(result);


public class Solution {
    public bool WordPattern(string pattern, string s) {
        var dict = new Dictionary<char, string>();
        var t = s.Split(' ');
        if(pattern.Length != t.Length) return false;
        for(int i = 0; i < pattern.Length; i++)
        {
            if(!dict.ContainsKey(pattern[i])) dict[pattern[i]] = t[i];
            else if(dict[pattern[i]] != t[i]) return false;
        }
        return dict.Values.Count == dict.Values.Distinct().Count();
    }
}