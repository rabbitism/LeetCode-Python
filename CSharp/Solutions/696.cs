using System;
using System.Collections.Generic;

namespace CSharp{

    public partial class Solution{
        public int CountBinarySubstrings(string s){
            List<int> count = new List<int>();
            char[] charArray = s.ToCharArray();
            char index = charArray[0];
            int seq = 0;
            int length = charArray.Length;
            for(int i = 0; i< length; i++){
                
                if(charArray[i]==index){
                    
                    seq+=1;
                }
                else{
                    count.Add(seq);
                    index = charArray[i];
                    seq=1;
                }
                if(i==length-1) count.Add(seq);
                Printer.Print(index+"\t"+seq);

            }
            int result = 0;
            Printer.Print(count);
            Printer.Print("\n");
            for(int i=0; i< count.Count-1; i++){
                result+=Math.Min(count[i],count[i+1]);
            }
        
            return result;
        }
    }
}