
namespace CSharp{
public partial class Solution {
    public int[] PlusOne(int[] digits) {
        int temp  = 1;
        int sum = 0;
        for(int i = digits.Length-1; i>=0; i--){
            sum = digits[i]+temp;
            if(sum<10){
                digits[i] = sum;
                temp = 0;
            }
            else{
                digits[i]=0;
                temp = 1;
            }
        }
        
        if(temp==1){
            int[] result = new int[digits.Length+1];
            result[0]=1;
            for(int i=1;i<digits.Length+1; i++){
                result[i] = digits[i-1];
            }
            return result;
        }
        else return digits;
        
        
    }
}

}