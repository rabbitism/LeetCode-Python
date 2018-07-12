using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharp{
public partial class Solution {
    public int DistributeCandies(int[] candies) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int candy in candies){
            if(dict.ContainsKey(candy)) dict[candy]++;
            else dict.Add(candy,1);
        }
        return Math.Min(dict.Count, candies.Length/2);
        
    }
}
}