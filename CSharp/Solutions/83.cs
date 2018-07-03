using System;

namespace CSharp{
public partial class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head ==null) return null;
        ListNode probe = head;
        ListNode result = head;
        ListNode resultProbe = result;
        while(probe!=null){
            if(probe.val==resultProbe.val){
                probe=probe.next;
            }
            else{
                resultProbe.next = new ListNode(probe.val);
                resultProbe = resultProbe.next;
                probe=probe.next;
            }
        }
        resultProbe.next = null;
        return result;
    }
}

}