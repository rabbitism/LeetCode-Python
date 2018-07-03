using System;
using System.Collections.Generic;

namespace CSharp{
    public class ListNode{
        public int val;
        public ListNode next;
        public ListNode(int x){val = x;}
    }

    public static class LinkedListGenerator{
        public static ListNode ArrayToLinkedList(int[] array){
            int length = array.Length; 
            if(length==0) return null;
            ListNode head = new ListNode(array[0]);
            if(length==1) return head;
            var pointer = head;
            for(int i = 1; i<length; i++){
                pointer.next = new ListNode(array[i]);
                pointer = pointer.next;
            }
            return head;
        }

        public static ListNode ListToLinkedList(List<int> list){
            int length = list.Count;
            if(length == 0) return null;
            ListNode head = new ListNode(list[0]);
            if(length==1) return head;
            var pointer = head;
            for(int i = 1; i<length; i++){
                pointer.next = new ListNode(list[i]);
                pointer = pointer.next;
            }
            return head;
        }


    }
}