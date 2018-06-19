using System;

namespace CSharp{
public partial class Solution {
    public int MinPathSum(int[,] grid) {
        int[,] sum = new int[grid.GetLength(0), grid.GetLength(1)];
        for(int i =0; i< grid.GetLength(0); i++){
            for(int j=0; j< grid.GetLength(1); j++){
                if(j == 0){
                    if(i==0) sum[i,j]=grid[i,j];
                    else sum[i,j] = sum[i-1,j]+grid[i,j];
                }
                if(j>0){
                    if(i == 0) sum[i,j]=sum[i,j-1]+grid[i,j];
                    else{
                        sum[i,j]=sum[i-1,j]>sum[i,j-1]?sum[i,j-1]+grid[i,j]:sum[i-1,j]+grid[i,j];
                    }
                }
            }
        }
        return sum[grid.GetLength(0)-1, grid.GetLength(1)-1];
    }
}
}