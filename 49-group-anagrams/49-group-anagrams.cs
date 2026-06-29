var result = new Solution().GroupAnagrams(["eat","tea","tan","ate","nat","bat"]);


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var word in strs)
        {
            var sortedWord = String.Concat(word.OrderBy(c => c));
            if(!dict.ContainsKey(sortedWord))
                dict[sortedWord] = new List<string>();
            dict[sortedWord].Add(word);
        }
        IList<IList<string>> result = [.. dict.Values];
        return result;
    }
}