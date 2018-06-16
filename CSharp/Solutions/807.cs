using System;

namespace CSharp{
public partial class Solution {
    //Solution1: Accepted.
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int[] horizontal = new int[grid.Length];
        int[] vertical = new int[grid[0].Length];
        for(int i = 0; i< grid.Length; i++){
            for(int j=0; j< grid[0].Length; j++){
                horizontal[i] = (int)Math.Max(horizontal[i], grid[i][j]);
                vertical[j] = (int)Math.Max(vertical[j], grid[i][j]);
            }
        }
        int sum = 0;
        for(int i = 0; i< grid.Length; i++){
            for(int j=0; j< grid[0].Length; j++){
                sum+=((int)Math.Min(horizontal[i],vertical[j])-grid[i][j]);
            }
        }
        return sum;
    }
}
}