using System.Linq;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        public IList<int> TopKFrequent(int[] nums, int k) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(var n in nums){
                if(dict.ContainsKey(n)) dict[n]+=1;
                else dict.Add(n,1);
            }
        
            return dict.ToList().OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList();
        }
    }

}