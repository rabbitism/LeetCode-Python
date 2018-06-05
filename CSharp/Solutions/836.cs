namespace CSharp{

    public partial class Solution{
        public bool IsRectangleOverlap(int[] rec1, int[] rec2){
            bool xOverLap = rec1[0]<rec2[0]?rec1[2]>rec2[0]:rec2[2]>rec1[0];
            bool yOverLap = rec1[1]<rec2[1]?rec1[3]>rec2[1]:rec2[3]>rec1[1];
            return xOverLap&&yOverLap;
        }

    }
}