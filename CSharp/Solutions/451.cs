using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CSharp{
public partial class Solution {
    public string FrequencySort(string s) {
        if(s.Length<=1) return s;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in s){
            if(dict.ContainsKey(c)) dict[c]+=1;
            else dict.Add(c,1);
        }
        var sorted = from pair in dict orderby pair.Value descending select pair;
        StringBuilder sb = new StringBuilder();
        foreach(var pair in sorted){
            sb.Append(pair.Key, pair.Value);
        }
        return sb.ToString();
    }
}

}