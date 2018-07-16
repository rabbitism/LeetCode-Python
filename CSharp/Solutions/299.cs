using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public string GetHint(string secret, string guess) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(char c in secret){
            if(dict.ContainsKey(c)) dict[c]++;
            else dict.Add(c,1);
        }
        
        int bull = 0;
        int cow = 0;
        
        for(int i = 0; i< secret.Length; i++){
            if(secret[i]==guess[i]){
                bull++;
                dict[secret[i]]--;
            }
        }
        for(int i = 0; i< secret.Length; i++){
            if(secret[i]!=guess[i]){
                if(dict.ContainsKey(guess[i])){
                    if(dict[guess[i]]>=1){
                        dict[guess[i]]--;
                        cow++;
                    }
                }
            }
        }
        return bull+"A"+cow+"B";
    }
}

}