using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {

    //Accepted.
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        if(findNums==null) return null;
        int[] result = new int[findNums.Length];
        for(int i = 0; i< findNums.Length; i++){
            int index = Array.IndexOf(nums,findNums[i]);
            result[i]=-1;
            for(int j = index+1; j<nums.Length; j++){
                if(nums[j]>findNums[i]){
                    result[i]=nums[j];
                    break;
                }

            }
        }
        return result;
    }
}

}