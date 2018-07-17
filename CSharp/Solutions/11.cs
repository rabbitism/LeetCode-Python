using System;

namespace CSharp{
public partial class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int result = 0;
        for(int i = 0;i<n-1;i++){
            for(int j = i+1; j<n; j++){
                result = Math.Max(Math.Min(height[i],height[j])*(j-i),result);
                Printer.Print(result);
            }
        }
        return result;
    }
}

}
