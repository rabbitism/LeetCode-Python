

namespace CSharp{
public partial class Solution {

    //Accepted. 
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        int row = obstacleGrid.GetLength(0);
        int column = obstacleGrid.GetLength(1);
        int[,] result = new int[row,column];
        for(int i = 0; i<row; i++ ){
            for(int j = 0; j<column; j++){
                if(i==0 && j==0) result[i,j]=obstacleGrid[i,j]==1?0:1;
                else if(i==0){
                    result[i,j]=obstacleGrid[i,j]==1?0:result[i,j-1];
                }
                else if(j==0){
                    result[i,j]=obstacleGrid[i,j]==1?0:result[i-1,j];
                }
                else{
                    result[i,j]=obstacleGrid[i,j]==1?0:result[i-1,j]+result[i,j-1];
                }
            }
        }
        return result[row-1,column-1];
    }
}
}