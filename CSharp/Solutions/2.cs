
namespace CSharp{
public partial class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int temp = 0;
        ListNode result = new ListNode(0);
        ListNode probe = result;
        ListNode leftProbe = l1;
        ListNode rightProbe = l2;
        while(leftProbe!=null || rightProbe!=null){
            int value1 = leftProbe==null?0:leftProbe.val;
            int value2 = rightProbe==null?0:rightProbe.val;
            int valueInList = value1+value2+temp>=10?value1+value2+temp-10:value1+value2+temp;
            temp = value1+value2+temp>=10?1:0;
            probe.next = new ListNode(valueInList);
            probe = probe.next;
            leftProbe=leftProbe==null?null:leftProbe.next;
            rightProbe = rightProbe==null?null:rightProbe.next;
        }
        if(temp==1){
            probe.next = new ListNode(1);
        }
        return result.next;
    }
}

}