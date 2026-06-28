var result = new Solution().IsValidSudoku(
[['8','3','.','.','7','.','.','.','.']
,['6','.','.','1','9','5','.','.','.']
,['.','9','8','.','.','.','.','6','.']
,['8','.','.','.','6','.','.','.','3']
,['4','.','.','8','.','3','.','.','1']
,['7','.','.','.','2','.','.','.','6']
,['.','6','.','.','.','.','2','8','.']
,['.','.','.','4','1','9','.','.','5']
,['.','.','.','.','8','.','.','7','9']]);
System.Console.WriteLine(result);

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var ListRows = Enumerable.Range(0, 9).Select(_ => new HashSet<int>()).ToList();
        var ListCol = Enumerable.Range(0, 9).Select(_ => new HashSet<int>()).ToList();
        var ListBox = Enumerable.Range(0, 9).Select(_ => new HashSet<int>()).ToList();

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if(board[i][j] == '.') continue;

                if (ListRows[i].Contains(board[i][j])) return false;
                else ListRows[i].Add(board[i][j]);

                if(ListCol[j].Contains(board[i][j])) return false;
                else ListCol[j].Add(board[i][j]);

                if(ListBox[(i/3)*3 + j/3].Contains(board[i][j])) return false;
                else ListBox[(i/3)*3 + j/3].Add(board[i][j]);
            }
        }
        return true;
    }
}