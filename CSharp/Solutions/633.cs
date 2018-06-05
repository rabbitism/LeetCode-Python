using System;

namespace CSharp{

    public partial class Solution {

        //Accepted
        public bool JudgeSquareSum(int c) {

            for(int i=0; i*i<=c/2; i++ ){
                double target = Math.Sqrt(c-i*i);
                if(target==(int)target) return true;
                
            }
            return false;
        }

        //If Sqrt function is not allowed, use binary search to implement same function. 


        public bool JudgeSquareSum_Option2(int c){
            int min = 0;
            int max = (int)Math.Sqrt(c);
            while(min<=max){
                int sum = min*min+max*max;
                if(sum<c) min++;
                if(sum>c) max--;
                if(sum==c) return true;
            }
            return false;
        }
    }
}