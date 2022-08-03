public class Solution {
    public int NumIslands(char[][] grid) {
        int n = grid.Length; 
        int m = grid[0].Length;
        
        int count = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == '1'){
                    count++;
                    DFS(grid, i, j);
                }
            }
        }
        
        return count;
        
    }
    
    public void DFS(char[][] grid, int i, int j){
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            return;
        grid[i][j] = '0';
        
        DFS(grid, i-1, j);
        DFS(grid, i+1, j);
        DFS(grid, i, j-1);
        DFS(grid, i, j+1);
        
    }
}