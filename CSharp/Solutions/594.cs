using System;
using System.Collections.Generic;

namespace CSharp{

    public partial class Solution{

        public int FindLHS(int[] nums){
            //Use HashMap(dictionary)
            
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach(var number in nums){
                if(dictionary.ContainsKey(number)){
                    dictionary[number]+=1;
                }
                else{
                    dictionary.Add(number, 1);
                }
            }

            int result = 0;

            if(dictionary.Keys.Count<=1||dictionary==null) return result;

            foreach(KeyValuePair<int,int> pair in dictionary){

                if(dictionary.ContainsKey(pair.Key+1)){
                    result = Math.Max(result, dictionary[pair.Key]+dictionary[pair.Key+1]);
                }

            }

            

            return result;
        } 
    }
}