using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp{
    public partial class Solution{
        public int UniqueMorseRepresentations(string[] words){
            List<string> dict = new List<string>(){".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
            List<string> translations = new List<string>();
            foreach(var word in words){
                StringBuilder sb = new StringBuilder();
                
                foreach(var c in word){
                    sb.Append(dict[(int)(c)-97]);
                }
                translations.Add(sb.ToString());
            }

            return translations.Distinct().ToList().Count;
        
        
        }
    }
}