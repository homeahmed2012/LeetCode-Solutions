var res = new Solution().WordBreak("catsandog", new List<string> {"cats","dog","sand","and","cat"});
System.Console.WriteLine(res);
Console.ReadLine();

public class Solution {
    Dictionary<string, bool> dp = new Dictionary<string, bool>();
    
    public bool WordBreak(string s, IList<string> wordDict) {
        if(dp.ContainsKey(s)) return dp[s];
        if(wordDict.Contains(s)) return dp[s] = true;
        for(int i = 1; i < s.Length; i++)
        {
            if(WordBreak(s[0..i], wordDict) && WordBreak(s[i..], wordDict))
            {
                return dp[s] = true;
            }
        }
        return dp[s] = false;
    }
}