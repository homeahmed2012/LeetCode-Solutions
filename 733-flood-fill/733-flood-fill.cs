public class Solution {
    int[,] visited;
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        visited = new int[image.Length, image[0].Length];
        Solve(image, sr, sc, color, image[sr][sc]);
        return image;
    }
    
    public void Solve(int[][] image, int x, int y, int color, int prev){
        if(x < 0 || y < 0 || x > image.Length -1 || y > image[0].Length -1) return;
        if(image[x][y] != prev) return;
        if(visited[x, y] == 1) return;
        prev = image[x][y];
        visited[x, y] = 1;
        image[x][y] = color;
        
        Solve(image, x-1, y, color, prev);
        Solve(image, x, y-1, color, prev);
        Solve(image, x, y+1, color, prev);
        Solve(image, x+1, y, color, prev);
    }
}