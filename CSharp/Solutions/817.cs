

namespace CSharp{
public partial class Solution {
    public int NumComponents(ListNode head, int[] G) {
        ListNode probe = head;
        int result = 0;
        bool flag = true;
        while(probe != null){
            if(flag && InArray(G, probe.val)){
                Printer.Print("1: "+probe.val);
                result+=1;
                flag = !flag;
                probe = probe.next;

            }
            else if(flag && !InArray(G, probe.val)){
                Printer.Print("2: "+probe.val);
                probe = probe.next;
            }
            else if(!flag && InArray(G, probe.val)){
                Printer.Print("3: "+probe.val);
                probe = probe.next;
            }
            else if(!flag && !InArray(G,probe.val)){
                Printer.Print("4: "+probe.val);
                flag = !flag;
                probe = probe.next;
            }
            
        }
        return result;
        
    }
    
    public bool InArray(int[] G, int target){
        
        for(int i = 0; i< G.Length; i++){
            if(G[i]==target){Printer.Print("true"); return true;} 
        }
        return false;
    }
}
}