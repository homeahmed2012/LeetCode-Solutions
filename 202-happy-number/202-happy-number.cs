public class Solution {
    public bool IsHappy(int n) {
        var dict = new HashSet<int>();

        while (n != 1)
        {
            if(dict.Contains(n)) return false;
            dict.Add(n);
            n = GetSum(n);
        }
        return true;
    }

    public int GetSum(int n)
    {
        int result = 0;
        while(n != 0)
        {
            int current = n%10;
            result += current * current;
            n /= 10;
        }
        return result;
    }
}