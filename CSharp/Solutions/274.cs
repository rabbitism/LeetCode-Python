
using System;

namespace CSharp{
public partial class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
        if(citations.Length==0 || citations[0]==0) return 0;
        else if(citations[0]!=0 && citations.Length==1) return 1;
        for(int i = 0; i< citations.Length-1; i++){
            if(citations[i]>=(i+1) && citations[i+1]<(i+2)) return i+1; 
        }
        return citations.Length;
    }
}

}