public class Solution {
    IList<string> res;
    int len;
    public IList<string> GenerateParenthesis(int n) {
        res = new List<string>();
        len = n*2;
        Solve(0, "");
        return res;
    }
    
    public void Solve(int opens, string str){
        if(opens < 0) return;
        if(str.Length == len){
            if(opens == 0) res.Add(str);
            return;
        }
        Solve(opens+1, str + "(");
        Solve(opens-1, str + ")");
    }
}