
namespace CSharp{
public partial class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        
        for(int i=1;i<row;i++){
            for(int j=1;j<column;j++){
                if(matrix[i,j]!=matrix[i-1,j-1]) return false;
            }
        }
        return true;
    }
}
}