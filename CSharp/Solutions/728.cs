using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {

    //Accepted.
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> list = new List<int>();
        for(int i=left; i<=right; i++){
            if(IsSelfDividing(i)) list.Add(i);
        }
        return list;
    }
    
    private bool IsSelfDividing(int i){
        int temp = i;
        bool result = true;
        while(temp>0){
            if(temp%10==0) return false;
            else if(i%(temp%10)!=0) return false;
            else{
                temp = temp/10;
            }
        }
        return result;
        
    }
}
}