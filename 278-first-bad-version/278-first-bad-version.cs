/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int s, e, mid;
        s = 1;
        e = n;
        while(s < e){
            mid = (e - s)/2 + s;
            if(IsBadVersion(mid)){
                e = mid;
            }else{
                s = mid+1;
            }
        }
        return e;
    }
}