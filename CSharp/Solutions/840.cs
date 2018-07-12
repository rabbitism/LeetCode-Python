

namespace CSharp{
public partial class Solution {

    //Accepted. 
    public int NumMagicSquaresInside(int[][] grid) {
        int row = grid.GetLength(0);
        int column = grid[0].GetLength(0);
        int sum = 0;
        for(int i = 1; i<= row-2; i++){
            for(int j = 1; j<= column-2; j++){
                if(grid[i][j]==5){
                    if(ContainAllDigits(grid[i-1][j-1],grid[i-1][j],grid[i-1][j+1],grid[i][j-1],grid[i][j],grid[i][j+1],grid[i+1][j-1],grid[i+1][j],grid[i+1][j+1])){
                        if(HorizontalSum(grid, i,j)){
                            if(VerticalSum(grid,i,j)){
                                if(DiagnalSum(grid,i,j)){
                                    sum++;
                                }
                                else continue;
                            }
                            else continue;
                        }
                        else continue;
                    }
                    else continue;
                }
                else continue;
            }
        }
        return sum;
    }
    public bool ContainAllDigits(params int[] values){
        int[] index = new int[10]{0,1,1,1,1,1,1,1,1,1};
        foreach(var i in values){
            if(i>9) return false;
            if(index[i]==0) return false;
            else index[i]=0;
        }   
        return true;
    }
    
    public bool HorizontalSum(int[][] grid, int i, int j){
        return grid[i-1][j-1]+grid[i-1][j]+grid[i-1][j+1]==15 && grid[i][j-1]+grid[i][j]+grid[i][j+1]==15 && grid[i+1][j-1]+grid[i+1][j]+grid[i+1][j+1]==15;
    }
    
    public bool VerticalSum(int[][] grid, int i, int j){
        return grid[i-1][j-1]+grid[i][j-1]+grid[i+1][j-1]==15 && grid[i-1][j]+grid[i][j]+grid[i+1][j]==15 && grid[i-1][j+1]+grid[i][j+1]+grid[i+1][j+1]==15;
    }
    
    public bool DiagnalSum(int[][] grid, int i, int j){
        return grid[i-1][j-1]+grid[i][j]+grid[i+1][j+1]==15&&grid[i+1][j-1]+grid[i][j]+grid[i-1][j+1]==15;
    }
}
}