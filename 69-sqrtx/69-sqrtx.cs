var result = new Solution().MySqrt(2147395599);
System.Console.WriteLine(result);

public class Solution {
    public int MySqrt(int x) {
        long s,e;
        s = 0; e = x;
        while (s < e)
        {
            long mid = s + (e - s + 1)/2;
            if(mid * mid > x) e = mid-1;
            else s = mid;
        }
        return (int)s;
    }
}
