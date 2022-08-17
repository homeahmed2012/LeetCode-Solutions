public class Solution {
    int[] occur = new int[150];
    public int LengthOfLongestSubstring(string s) {
        int st, e, max;
        st = e = max = 0;
        for(int i = 0; i < s.Length; i++){
            if(occur[(int)s[i]] > st){
                st = occur[(int)s[i]];
            }
            e++;
            occur[(int)s[i]] = e;
            max = Math.Max(max, e-st);
        }
        return max;
    }
}