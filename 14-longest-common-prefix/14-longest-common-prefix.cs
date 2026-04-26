public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        for(int i = 0; i < 200; i++)
        {
            if(strs[0].Length <= i) return strs[0][..i];
            for(int j = 1; j < strs.Length; j++)
            {
                if(strs[j].Length <= i || strs[j][i] != strs[0][i])
                    return strs[0][..i];
            }
        }
        return "";
    }
}