using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        if(A.Length<=2) return 0;
        int[] difference = new int[A.Length-1];
        for(int i = 0; i<A.Length-1; i++){
            difference[i] = A[i+1]-A[i];
        }
        int index = difference[0];
        int count = 0;
        List<int> list = new List<int>();
        for(int i = 0; i< difference.Length; i++){
            if(difference[i]==index){
                count+=1;
            }
            if(difference[i]!=index){
                if(count>=2) list.Add(count);
                index=difference[i];
                count=1;
            }
        }
        if(count>=2) list.Add(count);
        int result = 0;
        foreach(int i in list){
            result+=(i-1+1)*(i-1)/2;
        }
        return result;
    }
}

}