var result = new Solution().Merge([[4,7],[1,4]]);

foreach(var item in result)
{
    foreach(var x in item)
    {
        System.Console.Write($"{x} ");
    }
    System.Console.WriteLine();
}

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        int s, e;
        s = intervals[0][0];
        e = intervals[0][1];
        for(int i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] <= e)
            {
                e = Math.Max(e, intervals[i][1]);
            }
            else
            {
                result.Add([s, e]);
                s = intervals[i][0];
                e = intervals[i][1];
            }
        }
        result.Add([s, e]);
        return result.ToArray();
    }
}