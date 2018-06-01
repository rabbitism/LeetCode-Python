using System;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        public int[] FindErroNums(int[] nums){
            int duplicate = 0;
            int missing  =0;

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for(int i=1; i<=nums.Length; i++){
                dictionary.Add(i,0);
            }
            foreach(int num in nums){
                if(dictionary[num]==1) {duplicate=num; }
                else dictionary[num]=1;
            }

            foreach(KeyValuePair<int,int> pair in dictionary){
                if(pair.Value==0) missing=pair.Key;
            }

            return new int[2]{duplicate, missing};
        }
    }
}