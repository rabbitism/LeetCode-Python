using System.Collections.Generic;

namespace CSharp{
public partial class Solution {

    public int FindPairs(int[] nums, int k) {
        if(k<0) return 0;
        int result = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(var i in nums){
            if(dict.ContainsKey(i)) dict[i]++;
            else dict.Add(i,1);
        }
        foreach(var pair in dict){
            if(k==0){
                if(pair.Value>=2) result++;
            }
            else{
                if(dict.ContainsKey(pair.Key+k)) result++;
            }
        }
        return result;
    }
}

}