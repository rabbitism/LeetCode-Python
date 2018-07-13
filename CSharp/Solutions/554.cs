using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var list in wall){
            int sum = 0;
            for(int i = 0; i< list.Count-1;i++){
                sum+=list[i];
                if(dict.ContainsKey(sum)) dict[sum]++;
                else dict.Add(sum,1);
            }
            
        }
        int max = 0;
        foreach(var pair in dict){
            if(pair.Value>max) max= pair.Value;
        }
        return wall.Count-max;
    }
}
}