public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<string, int>
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000},
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900}
        };
        var result = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(i < s.Length - 1 && dict.ContainsKey(s.Substring(i, 2)))
            {
                result += dict[s.Substring(i++, 2)];
            }
            else
            {
                result += dict[s[i]+""];
            }
        }
        return result;
    }
}