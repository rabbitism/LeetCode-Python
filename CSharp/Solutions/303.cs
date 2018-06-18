using System;
using System.Collections.Generic;

namespace CSharp{
public class NumArray {
    Dictionary<int, int> dict = new Dictionary<int, int>();

    public NumArray(int[] nums) {
        if(nums.Length>=1) dict.Add(0, nums[0]);
        for(int i = 1; i< nums.Length; i++){
            dict.Add(i,dict[i-1]+nums[i]);
        }
    }
    
    public int SumRange(int i, int j) {
        if(i==0) return dict[j];
        else return dict[j]-dict[i-1];
    }
}
}