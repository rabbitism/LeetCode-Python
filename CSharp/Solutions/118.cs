using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<IList<int>> Generate(int numRows) {

        //Accepted. This failed many times during debugging, and the biggest learn is the copy of list. List is still considered as a pointer to the first element, so after assiging this list to a new variable, the two list are considred identical in memory.
        IList<IList<int>> result = new List<IList<int>>();
        if(numRows==0) return result;
        List<int> previous = new List<int>();
        List<int> current = new List<int>();
        for(int i = 1; i<= numRows; i++){
            if(i == 1){
                current = new List<int>{1};
                result.Add(new List<int>(current.ToArray()));
            }
            else if(i==2){
                current = new List<int>{1,1};
                result.Add(new List<int>(current.ToArray()));
            }
            else{
                previous = new List<int>(current.ToArray());
                current.Clear();
                current.Add(1);
                for(int j = 0; j< previous.Count-1; j++){
                    current.Add(previous[j]+previous[j+1]);
                }
                current.Add(1);
                result.Add(new List<int>(current.ToArray()));
            }
        }
        return result;
        
    }
}
}