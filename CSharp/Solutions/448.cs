using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> result = new List<int>();
        int[] index = new int[nums.Length+1];
        for(int i = 0; i< nums.Length; i++){
            index[nums[i]]=1;
        }
        for(int i = 1; i< index.Length; i++){
            if(index[i]==0) result.Add(i);
        }
        return result;
        
    }
}
}