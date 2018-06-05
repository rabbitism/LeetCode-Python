using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        public bool CanConstruct(string ransomNote, string magazine) {
            Dictionary<char, int> magazineDict = new Dictionary<char, int>();
            foreach(char c in magazine){
                if(magazineDict.ContainsKey(c)) magazineDict[c]+=1;
                else magazineDict.Add(c,1);
            }

            foreach(char c in ransomNote){
                if(magazineDict.ContainsKey(c)) magazineDict[c]-=1;
                else magazineDict.Add(c,-1);
            }

            foreach(var pair in magazineDict){
                if(pair.Value<0) return false;
            }
            
            return true;
        
        }
    }
}