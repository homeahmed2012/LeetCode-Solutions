public class Solution {
    public int LongestPalindrome(string s) {
        var dict = new Dictionary<char, int>();
        foreach(var c in s){
            if(!dict.ContainsKey(c)){
                dict.Add(c, 1);
            }
            else
            {
                dict[c] += 1;   
            }
        }
        int res = 0;
        int f = 0;
        foreach(var item in dict.Values){
            if(item % 2 == 0) res += item;
            else{
                res += item - 1;
                f = 1;
            } 
        }
        return res + f;
    }
}