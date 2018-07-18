

namespace CSharp{
public partial class Solution {
    public bool LemonadeChange(int[] bills) {
        int[] box = new int[2]{0,0};
        for(int i =0; i< bills.Length; i++){
            if(bills[i]==5){
                box[0]++;
                Printer.Print(box);
            }
            if(bills[i]==10){
                box[1]++;
                if(box[0]>0) box[0]--;
                else return false;
            }
            if(bills[i]==20){
                if(box[1]>0) {
                    box[1]--;
                    if(box[0]>0) box[0]--;
                    else return false;
                }
                else{
                    if(box[0]>=3) box[0]-=3;
                    else return false;
                }
            }
            
        }
        return true;
    }
}
}