using System.Collections.Generic;
using System;

namespace CSharp{
public partial class Solution {
    public IList<int> PartitionLabels(string S) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = S.Length-1; i>=0; i--){
            if(!dict.ContainsKey(S[i])) dict.Add(S[i],i);
        }
        int p1 = 0;
        int p2 = 0;
        List<int> result=  new List<int>();
        for(int i = 0; i<S.Length;i++){
            p2 = Math.Max(p2, dict[S[i]]);
            if(i==p2){
                result.Add(p2-p1+1);
                if(p2!=S.Length-1){
                    p1 = p2+1;
                    p2 = dict[S[p1]];
                }
                else{
                    break;
                }
            }
        }


        return result;
    }
}

}