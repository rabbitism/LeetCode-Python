using System;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        public bool RepeatedSubstringPattern(string s) {
            //Wrong
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach(char c in s){
                if(dictionary.ContainsKey(c)) dictionary[c]+=1;
                else dictionary.Add(c,1);
            }
            int minCount = s.Length;
            foreach(var pair in dictionary){
                if(pair.Value<minCount)
                    minCount = pair.Value;
            }
            if(minCount==1) return false;
            foreach(var pair in dictionary){
                if(pair.Value%minCount!=0) return false;
            }
            int length = s.Length/minCount;
            string initial = s.Substring(0, length);
            for(int i = 0; i< minCount; i++){
                string substring = s.Substring(i*length,length);
                if(substring!=initial) return false;
            }
            return true;
        
        }
    }
}
