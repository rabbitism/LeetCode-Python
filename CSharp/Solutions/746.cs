
namespace CSharp{
public partial class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int[] result = new int[cost.Length];
        for(int i = 0; i<cost.Length; i++){
            if(i<=1) result[i]=cost[i];
            else{
                result[i]=cost[i]+(result[i-1]>result[i-2]?result[i-2]:result[i-1]);
            }
        }
        return result[cost.Length-2]>result[cost.Length-1]?result[cost.Length-1]:result[cost.Length-2];
    }
}
}