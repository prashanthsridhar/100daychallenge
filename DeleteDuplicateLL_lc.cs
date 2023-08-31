/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode t=head;
        ListNode p=head;
        while(t.next!=null)
        {
            t=t.next;
            if(t.val==p.val)
            {
                if(t!=null&&p!=null)
                p.next=t.next;
                t=head;
                p=head;
                continue;
            }
            if(p.next!=null)   
            p=p.next;
        }
        return head;
        
    }
}
