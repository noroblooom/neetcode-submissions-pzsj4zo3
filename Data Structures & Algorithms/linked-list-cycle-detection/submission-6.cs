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
    public bool HasCycle(ListNode head) {
        var has = new HashSet<ListNode>();
        ListNode curr = head;

        while (curr != null) {
            if (has.Contains(curr)) {
                return true;
            }
            has.Add(curr);
            curr = curr.next;
        }

        return false;
    }
}
