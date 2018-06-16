using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public int IntegerBreak(int n) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(1,1);
        dict.Add(2,1);
        for(int i=3;i<=n;i++){
            int max = 0;
            foreach(var pair in dict){
                max = (int)Math.Max(max, pair.Value*(i-pair.Key));
            }
            dict.Add(i, max);
        }
        return dict[n];
    }
}
}