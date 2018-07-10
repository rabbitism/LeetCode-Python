using System;

namespace CSharp{
public partial class Solution {

    //Accepted. 
    public int FindLengthOfLCIS(int[] nums) {
        if(nums.Length<=1) return nums.Length;
        int length = 1;
        int maxLength = 1;
        for(int i = 1; i<nums.Length; i++){
            if(nums[i]>nums[i-1]){
                length +=1;
                if(i==nums.Length-1){
                    maxLength = Math.Max(maxLength, length);
                }
            }
            else{
                maxLength = Math.Max(maxLength, length);
                length = 1;
            }
        }
        return maxLength;
    }
}
}