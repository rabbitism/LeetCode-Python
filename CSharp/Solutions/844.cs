using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public bool BackspaceCompare(string S, string T) {
        Stack<char> SStack = new Stack<char>();
        Stack<char> TStack = new Stack<char>();
        foreach(char c in S){
            if(c=='#'){
                if(SStack.Count>0) SStack.Pop();
            }
            else{
                SStack.Push(c);
            }
        }
        
        foreach(char c in T){
            if(c=='#'){
                if(TStack.Count>0) TStack.Pop();
            }
            else{
                TStack.Push(c);
            }
        }
        
        if(SStack.Count!=TStack.Count) return false;
        else{
            for(int i = 0; i< SStack.Count; i++){
                if(SStack.Pop()!=TStack.Pop()) return false;
            }
        }
        return true;
    }
}

}