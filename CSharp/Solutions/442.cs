using System.Collections.Generic;

namespace CSharp{
public partial class Solution {

    //Accepted
    public IList<int> FindDuplicates(int[] nums) {
        int[] index = new int[nums.Length+1];
        List<int> result = new List<int>();
        for(int i = 0; i< index.Length; i++){
            index[i]=1;
        }
        for(int i = 0; i< nums.Length; i++){
            if(index[nums[i]]==1) index[nums[i]]=0;
            else result.Add(nums[i]);
        }
        return result;
    }
}
}