using System;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution {
        //Wrong answer
        public int MinSteps_2(int n) {
            int temp = n;
            int div = 2;
            List<int> list = new List<int>();
            while(div<=temp){
                if(temp%div==0){
                    list.Add(div);
                    temp = temp/div;
                }
                else{ div++;}
            }

            int sum = 0;
            foreach(var number in list){
                sum+=number;
            }
            return sum;
        }

        //More lean solution
        public int MinSteps(int n){
            int temp = n;
            int div = 2;
            int sum = 0;
            while(div<=temp){
                if(temp%div==0){
                    sum+=div;
                    temp = temp/div;
                }
                else{ div++;}
            }
            return sum;
            
        }
    }
}