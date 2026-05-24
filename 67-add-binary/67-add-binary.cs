var res = new Solution().AddBinary("1010", "1011");
System.Console.WriteLine(res);

public class Solution {
    public string AddBinary(string a, string b) {
        var result = "";
        var a_r = a.ToCharArray();
        var b_r = b.ToCharArray();
        Array.Reverse(a_r);
        Array.Reverse(b_r);
        var rem = 0;
        for(int i = 0; i < a.Length || i < b.Length; i++)
        {
            int x = i < a.Length ? a_r[i] - '0' : 0;
            int y = i < b.Length ? b_r[i] - '0' : 0;
            var sum = x + y + rem;
            rem = sum/2;
            result += Convert.ToString(sum%2);
        }
        if(rem > 0) result += "1";
        return new string(result.Reverse().ToArray());
    }
}