public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        foreach(var c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                st.Push(c);
            else if(st.Count > 0 && c - st.Peek() is < 3 and > 0)
                st.Pop();
            else
                return false;
        }
        return st.Count == 0;
    }
}