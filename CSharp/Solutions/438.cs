using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int totalLength = s.Length;
        int patternLength = p.Length;
        List<int> list=  new List<int>();
        for(int i = 0; i<= totalLength-patternLength; i++){
            string subString = s.Substring(i,patternLength);
            if(IsAnagram(subString, p)) list.Add(i);
        }
        return list;
    }
    public bool IsAnagram(string s1, string s2){
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in s1){
            if(dict.ContainsKey(c)) dict[c]++;
            else dict.Add(c,1);
        }
        foreach(char c in s2){
            if(dict.ContainsKey(c)) dict[c]--;
            else return false;
        }
        foreach(var pair in dict){
            if(pair.Value!=0) return false;
            else continue;
        }
        return true;
    }
}
}