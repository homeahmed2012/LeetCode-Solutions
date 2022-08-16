public class Solution {
    int[] visited = new int[50];
    public int ClimbStairs(int n) {
        if(n == 1 || n == 2) return n;
        if(visited[n] != 0) return visited[n];
        int res =  ClimbStairs(n-2) + ClimbStairs(n-1);
        visited[n] = res;
        return res;
    }
}