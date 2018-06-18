using System;
using System.Text;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0) return "";
        if(strs.Length==1) return strs[0];
        string commonPrefix = strs[0];
        for(int i=0; i<strs.Length; i++){
            if(commonPrefix=="" || commonPrefix==null) return "";
            int MinLength = (int)Math.Min(commonPrefix.Length, strs[i].Length);
            StringBuilder sb = new StringBuilder();
            for(int j=0; j< MinLength; j++){
                if(commonPrefix[j]==strs[i][j]){
                    sb.Append(commonPrefix[j]);
                }
                else break;
            }
            commonPrefix = sb.ToString();
        }
        return commonPrefix;
    }
}
}