using System;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{

        //Solution 1: Beats 96.77% submissions.
        public string[] FindRestaurant(string[] list1, string[] list2) {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for(int i=0; i< list1.Length; i++){
                dictionary.Add(list1[i], i);
            }
            List<string> resultList = new List<string>();
            int minIndexSum = list1.Length+list2.Length-1;
            for(int i=0; i< list2.Length; i++){
                if(dictionary.ContainsKey(list2[i])){
                    if(resultList==null || (dictionary[list2[i]]+i==minIndexSum)){
                        resultList.Add(list2[i]);
                    }
                    else if(dictionary[list2[i]]+i<minIndexSum){
                        resultList.Clear();
                        resultList.Add(list2[i]);
                        minIndexSum = dictionary[list2[i]]+i;
                    }
                }
            }
            return resultList.ToArray();
        }
    }
}