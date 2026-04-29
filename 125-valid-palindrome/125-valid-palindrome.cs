
var result = new Solution().IsPalindrome("A man, a plan, a canal: Panama");
System.Console.WriteLine(result);

public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray());
        return s.SequenceEqual(s.Reverse());
    }
}