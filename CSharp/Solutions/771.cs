using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        public int NumJewelsInStones(string J, string S){
            if(J.Length==0) return 0;
            List<char> list = new List<char>();
            foreach(char c in J){
                list.Add(c);
            }
            int sum = 0;
            foreach(char c in S){
                if(list.Contains(c)) sum+=1; 
            }
        
            return sum;
        }
    }
}