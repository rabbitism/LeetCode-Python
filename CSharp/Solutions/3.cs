using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length<=1) return s.Length;
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        int result = 0;
        int leftIndex = 0;
        int rightIndex = 0;
        for(int i = 0; i< s.Length; i++){
            rightIndex = i;
            if(!dictionary.ContainsKey(s[i])){
                dictionary.Add(s[i],i);
                result = (int)Math.Max(rightIndex-leftIndex+1, result);
            }
            else{
                if(leftIndex<=dictionary[s[i]]) leftIndex = dictionary[s[i]]+1;
                dictionary[s[i]]=i;
                result = (int)Math.Max(rightIndex-leftIndex+1, result);
            }
        }
        return result;
    }
}
}