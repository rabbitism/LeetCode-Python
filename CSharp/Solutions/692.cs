using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string word in words){
            if(dict.ContainsKey(word))dict[word]++;
            else dict.Add(word, 1);
        }
        var eList = from pair in dict orderby pair.Key ascending orderby pair.Value descending select pair.Key;
        var list = eList.ToList();
        List<string> result = new List<string>();
        for(int i = 0; i< k;i++){
            result.Add(list[i]);
        }

        return result.ToList();
    }
}

}