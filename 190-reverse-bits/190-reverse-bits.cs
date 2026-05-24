var result = new Solution().ReverseBits(43261596);
System.Console.WriteLine(result);

public class Solution {
    public int ReverseBits(int n) {
        int res = 0;
        var power = 31;
        while(n > 0)
        {
            res += n%2 * (1 << power--); 
            n = n/2;
        }
        return res;
    }
}

