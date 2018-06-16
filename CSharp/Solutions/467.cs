using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    //Apriori. Time Limit Exceeded.
    public int FindSubstringInWraproundString(string p) {
        List<string> initial = new List<string>();
        for(int i=0; i< p.Length; i++){
            if(!initial.Contains(p[i].ToString())) initial.Add(p[i].ToString());
            if(initial.Count==26) break;
        }
        int stringLength = 1;
        int result = 0;
        while(stringLength<=p.Length){
            result+=initial.Count;
            List<string> temp = FindSubstring(p, initial);
            if(temp.Count==0) break;
            else{
                initial.Clear();
                initial=temp;
                stringLength++;
            }
        }
        return result;
        
    }

    
    public List<string> FindSubstring(string p, List<string> list){
        List<string> result = new List<string>();
        foreach(var s in list){
            string newString = ExtendString(s);
            if(p.Contains(newString)) result.Add(newString);
        }
        return result;
    }
    
    public string ExtendString(string s){
        char c = s[s.Length-1];
        if(c=='z') return s+'a';
        else return s+(char)(c+1);
    }
}
}