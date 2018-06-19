using System;

namespace CSharp{
public partial class Solution {
    public int[] ConstructRectangle(int area) {
        double opt = Math.Sqrt(area);
        if(opt == (int)opt) return new int[2]{(int)opt, (int)opt};
        else{
            for(int i=(int)opt+1; i<= area; i++){
                if(area%i==0) return new int[2]{i,area/i}; 
            }
        }
        return new int[]{area, 1};
    }
}
}