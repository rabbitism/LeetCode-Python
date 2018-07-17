using System;
using System.Text;

namespace CSharp{
public partial class Solution {
    public string Convert(string s, int numRows) {
        StringBuilder[] sb = new StringBuilder[numRows];
        for(int i = 0; i< sb.Length; i++){
            sb[i] = new StringBuilder();
        }
        int flag = 0;
        int increase = -1;
        for(int i = 0; i< s.Length; i++){
            if(flag==0){
                sb[flag].Append(s[i]);
                flag++;
                increase = 1;
            }
            else if(flag == numRows-1){
                sb[flag].Append(s[i]);
                flag--;
                increase = -1;
            }
            else{
                sb[flag].Append(s[i]);
                flag+=increase;
            }
            
        }
        string result = "";
        for(int i = 0; i< sb.Length; i++){
            result+=sb[i].ToString();
        }
        return result;
        
    }
}


}