public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) 
    {
        var dummy = new ListNode(0);
        dummy.next = head;
        var pre = dummy;
        var start = dummy;
        var end = dummy;
        var nxt = dummy;
        
        while (end.next != null)
        {
            for (int i = 0; i < k && end != null; i++)
            {
                end = end.next;
            }
            if (end == null)
                break;
            
            start = pre.next;
            nxt = end.next;
            // 反轉前k個元素, 不含nxt
            pre.next = reverse(start, nxt);
            // 鏈結後面的鏈表
            start.next = nxt;
            // pre, end 重置下一個k子鏈表
            pre = start;
            end = pre;
        }
        return dummy.next;
    }
    
    private ListNode reverse (ListNode start, ListNode end)
    {
        ListNode pre = null;
        ListNode cur = start;
        ListNode nxt = start;
        while (cur != end)
        {
            nxt = cur.next;
            // 逐節點反轉
            cur.next = pre;
            // 更新指針位置
            pre = cur;
            cur = nxt;
        }
        return pre;
    }
}