using System;
using System.Text;

namespace CSharp{
public partial class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        string condensedString = S.Replace("-","");
        if(condensedString.Length<=K) return condensedString.ToUpper();
        int firstGroupLength = condensedString.Length%K;
        StringBuilder sb = new StringBuilder();
        sb.Append(condensedString.Substring(0,firstGroupLength));
        if(firstGroupLength!=0) sb.Append("-");
        int sectionLength = 0;
        for(int i = firstGroupLength; i<condensedString.Length;i++){
            if(sectionLength<K){
                sb.Append(condensedString[i]);
                sectionLength+=1;
            }
            else{
                sb.Append("-");
                sb.Append(condensedString[i]);
                sectionLength=1;
            }
        }
        return sb.ToString().ToUpper();
        
    }
}    
}
