using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp{

    public partial class Solution{

        //This solution is wrong, because remaining words are not sequantially maintained. 
        public int MinDistance(string word1, string word2){
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach(char c in word1){
                if(dictionary.ContainsKey(c)) dictionary[c]+=1;
                else dictionary.Add(c,1);
            }
            foreach(char c in word2){
                if(dictionary.ContainsKey(c)) dictionary[c]-=1;
                else dictionary.Add(c,-1);
            }
            int sum = 0;
            foreach(var p in dictionary)
            {
                sum+= Math.Abs(p.Value);

            }

            return sum;
        }
    }


}