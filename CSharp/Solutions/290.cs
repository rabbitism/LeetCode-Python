using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public bool WordPattern(string pattern, string str) {
        string[] stringArray = str.Split(' ');
        if(stringArray.Length!=pattern.Length) return false;
        Dictionary<char, string> dict = new Dictionary<char, string>();
        for(int i = 0; i< pattern.Length; i++){
            if(!dict.ContainsKey(pattern[i]) && !dict.ContainsValue(stringArray[i])){
                dict.Add(pattern[i],stringArray[i]);
            } 
            else if(!dict.ContainsKey(pattern[i]) && dict.ContainsValue(stringArray[i])){
                return false;
            }
            else if(dict.ContainsKey(pattern[i])){
                if(dict[pattern[i]]==stringArray[i]) continue;
                else return false;
            }
            
        }
        return true;
    }
}

}