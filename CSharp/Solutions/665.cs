
namespace CSharp{
public partial class Solution {
    public bool CheckPossibility(int[] nums) {
        //Accepted. 
        if(nums.Length<=2) return true;
        int count = 0;
        int firstIndex = -1;
        for(int i=1; i<nums.Length;i++){
            if(nums[i]<nums[i-1]){
                if(firstIndex==-1) firstIndex = i;
                count++;
            }
        }
        if(count>=2) return false;
        if(count==0) return true;
        else{
            if(firstIndex == 1 || firstIndex == nums.Length-1) return true;
            else{
                if(nums[firstIndex-1]<=nums[firstIndex+1]||nums[firstIndex-1]<=nums[firstIndex+1]) return true;
                else return false;
            }
        }
    }
}

}