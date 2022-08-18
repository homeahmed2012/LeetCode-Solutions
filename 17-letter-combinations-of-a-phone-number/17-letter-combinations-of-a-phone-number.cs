public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var phoneButtons = new Dictionary<int, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };
        
        var res = new List<string>();
        Solve(0, "");
        return res;
        void Solve(int index, string str){
            if(index >= digits.Length){
                if(str.Length > 0) res.Add(str);
                return;                
            } 
            foreach(var item in phoneButtons[digits[index]]){
                Solve(index+1, str + item);
            }
        }
        
    }
}