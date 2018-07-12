using System.Text;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public string[] FindWords(string[] words) {
        List<string> list = new List<string>();
        Dictionary<char, int> dict = new Dictionary<char, int>{{'q',1},{'w',1},{'e',1},{'r',1},{'t',1},{'y',1},{'u',1},{'i',1},{'o',1},{'p',1},{'a',2},{'s',2},{'d',2},{'f',2},{'g',2},{'h',2},{'j',2},{'k',2},{'l',2},{'z',3},{'x',3},{'c',3},{'v',3},{'b',3},{'n',3},{'m',3}};
        foreach(string word in words){
            string w = word.ToLower();
            if(word.Length<=1) list.Add(w);
            else{
                int row = dict[w[0]];
                bool flag = true;
                foreach(char c in w){
                    if(dict[c]!=row){
                        flag = false;
                        break;
                    }
                }
                if(flag == true) list.Add(word);
            }
        }
        return list.ToArray();
    }
}
}