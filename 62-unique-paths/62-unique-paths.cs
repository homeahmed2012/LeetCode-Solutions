public class Solution {
    int[,] visited = new int[110, 110];
    
    public int UniquePaths(int m, int n) {
        visited[0, 0] = 1;
        return Solve(m-1, n-1);
    }
    
    public int Solve(int a, int b){
        if(a < 0 || b < 0) return 0;
        if(visited[a, b] !=  0) return visited[a, b];
        visited[a, b] = Solve(a-1, b) + Solve(a, b-1);
        return visited[a,b];
    }
}