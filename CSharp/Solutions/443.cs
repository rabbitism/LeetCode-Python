using System;

namespace CSharp{
public partial class Solution {

    //Wrong answer. This is not a in-place algorithm.
    public int Compress(char[] chars) {
        int result = 0;
        char index = chars[0];
        int count = 0;
        foreach(char c in chars){
            if(c==index){
                count+=1;
            }
            else{
                result+=1;
                if(count >1){
                    result+=count.ToString().Length;
                }
                index = c;
                count = 1;
            }
        }
        result+=1;
        if(count >1){
            result+=count.ToString().Length;
        }
        return result;

    }
}
}