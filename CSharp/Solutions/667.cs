
namespace CSharp{
public partial class Solution {
    public int[] ConstructArray(int n, int k) {
        int interval = n-1;
        int increase = 1;
        int jump = k-1;
        int[] result = new int[n];
        result[0]=1;
        int temp = 1;
        int index = 1;
        while(jump>0){
            temp = temp+increase*interval;
            result[index]=temp;
            jump--;
            interval--;
            increase = -increase;
            index++;
        }
        while(index<n){
            temp = temp+increase*1;
            result[index]=temp;
            index++;
        }
        
        
        return result;
    }
}

}