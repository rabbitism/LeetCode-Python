namespace CSharp
{

    public partial class Solution{

        //Brutal Force
        public int[] TwoSum(int[] nums, int target){

            var result = new int[2];
            for(int i=0;i<nums.Length;i++){
                for(int j=i+1;j<nums.Length;j++){
                    if(nums[i]+nums[j]==target)
                        result = new int[]{i,j};
                }
            }
            return result;
        }
    }
}