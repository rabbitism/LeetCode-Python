using System;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        //Wrong solution. THis solution is not implemented with linear time complexity and no extra space.
        public int SingleNumber(int[] nums) {
            //Implementation without considering memory?
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach(var number in nums){
                if(dictionary.ContainsKey(number)) dictionary[number]+=1;
                else dictionary.Add(number,1);
            }
            foreach(var pair in dictionary){
                if(pair.Value==1) return pair.Key;
            }
            return 0;
        }
    }
}