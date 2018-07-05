using System.Collections.Generic;


namespace CSharp{
public partial class Solution {
    public bool IsPalindrome(ListNode head) {
        List<int> list = new List<int>();
        ListNode probe = head;
        while(probe!=null){
            list.Add(probe.val);
            probe = probe.next;
        }
        int n = list.Count-1;
        int i = 0;
        while(i<=n-i){
            if(list[i]!=list[n-i]) return false;
            i++;
        }
        return true;
    }
}
}