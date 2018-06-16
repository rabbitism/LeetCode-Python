using System;
using System.Collections.Generic;

namespace CSharp{
    //Solution 1: TLE.
    public class Trie{
        List<string> list;

        /** Initialize your data structure here. */
        public Trie() {
            list = new List<string>();
        }
    
        /** Inserts a word into the trie. */
        public void Insert(string word) {
            list.Add(word);
        }
    
        /** Returns if the word is in the trie. */
        public bool Search(string word) {
            return list.Contains(word);
        }
    
        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix) {
            int length = prefix.Length;
            foreach(var s in list){
                if(length<= s.Length && s.Substring(0, length)==prefix) return true;
            }
            return false;
        }
    }
}