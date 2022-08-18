public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var res = new List<IList<int>>();
        Solve(new List<int>());
        return res;
        void Solve(List<int> arr){
            if(arr.Count == nums.Length){
                res.Add(arr.GetRange(0, arr.Count));
                return;
            }
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] > -20){
                    var temp = nums[i];
                    arr.Add(nums[i]);
                    nums[i] = -20;
                    Solve(arr);
                    nums[i] = temp;
                    arr.RemoveAt(arr.Count -1);
                }
            }
        }
    }
}