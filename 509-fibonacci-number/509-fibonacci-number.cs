public class Solution {
    public int Fib(int n) {
        if(n == 0 || n == 1) return n;
        var res = new int[35];
        res[0] = 0; res[1] = 1;
        for(int i = 2; i <= n; i++)
        {
            res[i] = res[i-1]+res[i-2];
        }
        return res[n];
    }
}