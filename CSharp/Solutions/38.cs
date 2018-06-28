using System;
using System.Text;

namespace CSharp{
public partial class Solution {

    //Accepted.
    public string CountAndSay(int n) {
        string s = "1";
        for(int i = 1; i<n; i++){
            s = UpdateString(s);
        }
        return s;
    }
    public string UpdateString(string s){
        StringBuilder stringBuilder = new StringBuilder();
        int count = 0;
        char target = s[0];
        foreach(var c in s){
            if(target != c){
                stringBuilder.Append(count);
                stringBuilder.Append(target);
                target = c;
                count=1;
            }
            else if(target==c){
                count+=1;
            }
        }
        stringBuilder.Append(count);
        stringBuilder.Append(target);
        return stringBuilder.ToString();
    }
}
}