

namespace CSharp{
public partial class Solution {

    ///Accepted. This is for Weekly Contest 92
    public int[][] Transpose(int[][] A) {
        int row = A.Length;
        int column = A[0].Length;
        int[][] result = new int[column][];

        for(int i =0; i<column; i++){
            int[] temp = new int[row];
            for(int j=0; j<row; j++){
                temp[j] = A[j][i];
            }
            result[i] = temp;
        }
        return result;
    }
}

}