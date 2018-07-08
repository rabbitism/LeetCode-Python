using System;

namespace CSharp{
public partial class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null) return null;
        ListNode probe = head;
        int count = 0;
        while (probe!=null){
            count+=1;
            probe = probe.next;
        }
        if(count == n) return head.next;
        if(count<n) return head;

        probe = head;
        int i = 0;
        while (i<count-n-1){
            i+=1;
            probe = probe.next;
        }
        probe.next= n==1?null:probe.next.next;
        return head;
    }
}

}