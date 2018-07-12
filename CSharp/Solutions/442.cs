using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> result = new List<int>();
        List<int> temp = new List<int>();
        for(int i = 0; i< nums.Length; i++){
            if(!temp.Contains(nums[i])) temp.Add(nums[i]);
            else result.Add(nums[i]);
        }
        return result;
    }
}
}