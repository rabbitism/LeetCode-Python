using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    ///Accepted.
    public int FindShortestSubArray(int[] nums) {
        Dictionary<int, int> count =  new Dictionary<int, int>();
        Dictionary<int, int> minIndex = new Dictionary<int, int>();
        Dictionary<int, int> maxIndex = new Dictionary<int, int>();
        for(int i = 0; i< nums.Length; i++){
            if(count.ContainsKey(nums[i])) count[nums[i]]+=1;
            if(!count.ContainsKey(nums[i])) count.Add(nums[i],1);
            if(!minIndex.ContainsKey(nums[i])) minIndex.Add(nums[i],i);
            if(!maxIndex.ContainsKey(nums[i])) maxIndex.Add(nums[i],i);
            if(maxIndex.ContainsKey(nums[i])) maxIndex[nums[i]]=i;
        }
        List<int> mostFrequent = new List<int>();
        int max = 0;
        foreach(var pair in count){
            if(pair.Value>max){
                max = pair.Value;
                mostFrequent.Clear();
                mostFrequent.Add(pair.Key);
            }
            else if(pair.Value==max){
                mostFrequent.Add(pair.Key);
            }
        }
        int maxLength = nums.Length;
        foreach(var item in mostFrequent){
            maxLength = Math.Min(maxLength, maxIndex[item]-minIndex[item]+1);
        }
        
        return maxLength;
    }
}
}