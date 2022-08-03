public class Solution {
    Dictionary<int, List<int>> adjList;
    HashSet<int> visited;
    public int NumIslands(char[][] grid) {
        int n = grid.Length; 
        int m = grid[0].Length;
        adjList = new Dictionary<int, List<int>>();
        visited = new HashSet<int>();
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == '1'){
                    var temp = new List<int>();
                    if(i > 0 && grid[i-1][j] == '1') temp.Add((i-1) *m +j);
                    if(i < n-1 && grid[i+1][j] == '1') temp.Add((i+1) *m +j);
                    if(j > 0 && grid[i][j-1] == '1') temp.Add(i *m +j -1);
                    if(j < m-1 && grid[i][j+1] == '1') temp.Add(i *m +j +1);
                    adjList.Add(i*m+j, temp);
                }
            }
        }
        
        int count = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == '1' && !visited.Contains(i*m+j)){
                    count++;
                    DFS(i*m+j);
                }    
            
            }
        }
        return count;
        
    }
    
    public void DFS(int node){
        visited.Add(node);
        foreach(var item in adjList[node]){
            if(!visited.Contains(item))
                DFS(item);
        }
    }
}