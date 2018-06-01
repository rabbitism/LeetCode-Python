using System;

namespace CSharp{
    public partial class Solution{
        public int LongestConsecutive(int[] nums){
            if(nums.Length==0) return 0;
            Array.Sort(nums);
            int longestS = 1;
            int currentS = 1;
            for(int i=1;i<nums.Length;i++){
                if(nums[i]==nums[i-1]+1)
                {
                    currentS+=1;
                    if(currentS>longestS) longestS=currentS;
                }
                else if(nums[i]==nums[i-1]) continue;
                else{
                    currentS=1;
                }
            }

            return longestS;
        }
    }
}