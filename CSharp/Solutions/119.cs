using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<int> GetRow(int rowIndex) {
        var pre = new List<int>();
        var cur = new List<int>();
        for(int i = 0; i<=rowIndex; i++){
            if(i == 0){
                cur = new List<int>{1};
            }
            else if(i == 1){
                cur = new List<int>{1,1};
            }
            else{
                pre = new List<int>(cur.ToArray());
                cur.Clear();
                cur.Add(1);
                for(int j=0; j< pre.Count-1; j++){
                    cur.Add(pre[j]+pre[j+1]);
                }
                cur.Add(1);
            }
        }
        return cur;
    }
}
}