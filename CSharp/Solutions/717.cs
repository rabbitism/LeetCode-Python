
namespace CSharp{
public partial class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        if(bits.Length==1) return true;
        if(bits.Length==2) return bits[0]!=1;
        int i = 0;
        while(true){
            if(bits[i]==1)i+=2;
            else i+=1;
            if(i==bits.Length-1) return true;
            if(i==bits.Length) return false;
        }
        
    }
}
}