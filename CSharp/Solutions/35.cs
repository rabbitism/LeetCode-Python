namespace CSharp{
    public partial class Solution{
        public int SearchInsert(int[] nums, int target){
            int min = 0;
            int max = nums.Length-1;
            int mid = (max-min)/2+min;
            if(target > nums[max]) return max+1;
            if(target < nums[0]) return 0;
	        while(nums[mid]!=target){
                if((max-min)==1) return min+1;
	            else{
                    if(nums[mid]>target){
                        max = mid;
                        mid = (max-min)/2+min;
                    }
                    else{
                        min = mid;
                        mid = (max-min)/2+min;
                    }

                }

            }
            return mid;
        }
    }
}