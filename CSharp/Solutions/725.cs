

namespace CSharp{
public partial class Solution {
    public ListNode[] SplitListToParts(ListNode root, int k) {
        ListNode[] result = new ListNode[k];
        int count= 0;
        ListNode probe = root;
        while(probe != null){
            count+=1;
            probe = probe.next;
        }
        probe = root;
        int minLength = count/k;
        int maxGroup = count%k;
        int m = 0;
        for(int i = 0; i<k; i++){
            if(i<maxGroup){
                for(int j = 0; j<minLength+1; j++){
                    if(j==0){
                        result[m]= probe;
                        m+=1;
                    }
                    probe = probe==null?null:probe.next;
                }     
            }
            else{
                for(int j = 0; j<minLength; j++){
                    if(j==0){
                        result[m]=probe;
                        m+=1;
                    } 
                    probe = probe==null?null:probe.next;
                } 
            }
           
        }
        return result;
        
    }
}

}