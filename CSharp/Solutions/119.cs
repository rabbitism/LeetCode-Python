using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<int> GetRow(int rowIndex) {
        if(rowIndex == 0) return new List<int>{1};
        if(rowIndex == 1) return new List<int>{1,1};
        else{
            List<int> result = new List<int>();
            result.Add(1);
            for(int i=0; i< rowIndex-1; i++){
                result.Add(GetRow(rowIndex-1)[i]+GetRow(rowIndex-1)[i+1]);
            }
            result.Add(1);
            return result;
        }
        
    }
}
}