using System;
using System.Text;

namespace CSharp
{
    public partial class Solution {
    //Solution 1: Time Limit Exceeded. The reason is when string is extended, unnecessary parts are calculated. This can be optimized.
    public int KthGrammar_2(int N, int K) {
        string temp = "0";
        for(int i=1; i< N; i++){
            temp = GetExtendedString(temp);
        }
        return  (Int32)temp[K-1]-48;
    }
    
    public string GetExtendedString(string s){
        StringBuilder sb = new StringBuilder("");
        foreach(char c in s){
            if(c=='0') sb.Append("01");
            else sb.Append("10");
        }
        return sb.ToString();
    }

    public int KthGrammar(int N, int K) {
        int initial = 0;
        int mid = (int)Math.Pow(2, N-2);
        int diff = (int)Math.Pow(2, N-2);
        for(int i=0; i< N; i++){
            diff = diff/2;
            if(K>=mid) {
                initial = GetRight(initial);
                mid = mid+diff;
            }
            else{
                initial = GetLeft(initial);
                mid = mid-diff;
            }
        }
        return initial;
    }
    
    public int GetLeft(int i){
        if(i==0) return 0;
        else return 1;
    }
    
    public int GetRight(int i){
        if(i==0) return 1;
        else return 0;
    }
}    
}