

namespace CSharp{
public partial class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        int[][] result = new int[A.GetLength(0)][];
        int column = A[0].GetLength(0);
        for(int i = 0;i<A.GetLength(0);i++){
            int[] tempRow = new int[A[0].GetLength(0)];
            for(int j = column-1;j>=0;j--){
                tempRow[j] = A[i][column-1-j]==1?0:1;
            }
            result[i] = tempRow;
        }
        return result;
    }
}
}