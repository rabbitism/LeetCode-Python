using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<IList<int>> LargeGroupPositions(string S) {
        char mark = S[0];
        int count = 0;
        int min = 0;
        int max = 0;
        
        IList<IList<int>> result = new List<IList<int>>();
        
        for(int i = 0; i<S.Length; i++){
            if(S[i]==mark){
                count+=1;
                max = i;
                if(i==S.Length-1 && count>=3){
                    result.Add(new List<int>{min,max});
                }
            }
            else{
                if(count>=3){
                    result.Add(new List<int>{min,max});
                }
                mark = S[i];
                min = i;
                max = i;
                count = 1;
            }
        }
        
        return result;
    }
}
}